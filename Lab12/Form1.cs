using System;
using System.IO;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Lab12
{
    public partial class Form1 : Form
    {
        private Word.Application wordApp;
        private Word.Document wordDoc;

        private string templatesFolder;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string defaultFolder = Path.Combine(Application.StartupPath, "Templates");

            string developmentFolder = "";
            try
            {
                var parent1 = Directory.GetParent(Application.StartupPath);
                var parent2 = parent1 != null ? Directory.GetParent(parent1.FullName) : null;
                if (parent2 != null)
                {
                    developmentFolder = Path.Combine(parent2.FullName, "Templates");
                }
            }
            catch { }

            if (Directory.Exists(developmentFolder) &&
                File.Exists(Path.Combine(developmentFolder, "Fax1.dotx")))
            {
                templatesFolder = developmentFolder;
            }
            else
            {
                templatesFolder = defaultFolder;
                if (!Directory.Exists(templatesFolder))
                {
                    Directory.CreateDirectory(templatesFolder);
                }
            }

            comboBoxTemplates.Items.Clear();

            string fax1Path = Path.Combine(templatesFolder, "Fax1.dotx");
            string fax2Path = Path.Combine(templatesFolder, "Fax2.dotx");

            if (File.Exists(fax1Path)) comboBoxTemplates.Items.Add("Fax1.dotx");
            if (File.Exists(fax2Path)) comboBoxTemplates.Items.Add("Fax2.dotx");

            if (comboBoxTemplates.Items.Count == 0)
            {
                comboBoxTemplates.Items.Add("Fax1.dotx");
                comboBoxTemplates.Items.Add("Fax2.dotx");

                MessageBox.Show($"Переконайтеся, що файли шаблонів 'Fax1.dotx' та 'Fax2.dotx' на місці",
                                "Підказка щодо шаблонів", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            comboBoxTemplates.SelectedIndex = 0;

            btnFindReplace.Enabled = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (comboBoxTemplates.SelectedItem == null)
            {
                MessageBox.Show("Оберіть файл шаблону зі списку!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedTemplate = Path.Combine(templatesFolder, comboBoxTemplates.SelectedItem.ToString());

            if (!File.Exists(selectedTemplate))
            {
                MessageBox.Show($"Перевірте наявність файлу.",
                                "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (wordApp == null)
                {
                    wordApp = new Word.Application();
                }

                wordApp.Visible = true;

                object templatePath = selectedTemplate;
                object missing = System.Reflection.Missing.Value;

                wordDoc = wordApp.Documents.Add(ref templatePath, ref missing, ref missing, ref missing);
                wordDoc.Activate();

                foreach (Word.FormField field in wordDoc.FormFields)
                {
                    switch (field.Name)
                    {
                        case "ToUser":
                            field.Range.Text = txtToUser.Text;
                            break;
                        case "FromUser":
                            field.Range.Text = txtFromUser.Text;
                            break;
                        case "Fax":
                            field.Range.Text = txtFax.Text;
                            break;
                        case "FaxPage":
                            field.Range.Text = txtFaxPage.Text;
                            break;
                        case "FaxPhone":
                            field.Range.Text = txtFaxPhone.Text;
                            break;
                        case "FaxDate":
                            field.Range.Text = txtFaxDate.Text;
                            break;
                        case "FaxGoal":
                            field.Range.Text = txtFaxGoal.Text;
                            break;
                        case "FaxCopy":
                            field.Range.Text = txtFaxCopy.Text;
                            break;
                        case "FaxText":
                            field.Range.Text = txtFaxText.Text;
                            break;
                        case "FaxNotes":
                            field.Range.Text = txtFaxNotes.Text;
                            break;
                    }
                }

                btnFindReplace.Enabled = true;
                MessageBox.Show($"Факс на основі бланка {comboBoxTemplates.SelectedItem} успішно сформовано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Критична помилка COM-сервера Word: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CloseWordReferences();
            }
        }

        private void btnFindReplace_Click(object sender, EventArgs e)
        {
            if (wordDoc == null) return;

            string searchTxt = txtSearch.Text;
            string replaceTxt = txtReplace.Text;

            if (string.IsNullOrEmpty(searchTxt))
            {
                MessageBox.Show("Вкажіть слово, яке потрібно знайти в тексті.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Word.Find findObject = wordApp.Selection.Find;
                findObject.ClearFormatting();
                findObject.Replacement.ClearFormatting();

                findObject.Text = searchTxt;
                findObject.Replacement.Text = replaceTxt;

                object replaceAll = Word.WdReplace.wdReplaceAll;
                object missing = System.Reflection.Missing.Value;

                bool found = findObject.Execute(
                    ref missing, ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing, ref missing,
                    ref replaceAll, ref missing, ref missing, ref missing, ref missing);

                if (found)
                    MessageBox.Show("Заміну слів у тексті бланка успішно виконано!", "Успішно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Вказаного слова в документі факсу не знайдено", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка під час виконання операції заміни: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            if (wordDoc == null)
            {
                MessageBox.Show("Немає активного документа для збереження! Спочатку згенеруйте факс.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            saveFileDialog1.Filter = "Документ Word (*.docx)|*.docx";
            saveFileDialog1.Title = "Оберіть шлях для збереження заповненого факсу";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    object fileName = saveFileDialog1.FileName;
                    object missing = System.Reflection.Missing.Value;

                    wordDoc.SaveAs2(ref fileName, ref missing, ref missing, ref missing,
                                    ref missing, ref missing, ref missing, ref missing,
                                    ref missing, ref missing, ref missing, ref missing,
                                    ref missing, ref missing, ref missing, ref missing);

                    MessageBox.Show("Документ факсу успішно збережено!", "Збережено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка запису файлу на вказаний шлях: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CloseWordReferences()
        {
            try
            {
                if (wordDoc != null)
                {
                    wordDoc.Close(false);
                    wordDoc = null;
                }
                if (wordApp != null)
                {
                    wordApp.Quit();
                    wordApp = null;
                }
            }
            catch { }
            btnFindReplace.Enabled = false;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseWordReferences();
        }
    }
}