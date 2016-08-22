using System;
using System.IO;
using System.Net;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;

namespace IKCWH5
{
    public partial class Form1 : Form
    {
        DataSet DataSetObject = new DataSet();
        static string connectionString = ConfigurationManager.ConnectionStrings["stock"].ConnectionString;
        SqlConnection SqlConnectionObject = new SqlConnection(connectionString);
        SqlDataAdapter SqlDataAdapterObject = new SqlDataAdapter();
        BindingSource BindingSourceObject = new BindingSource();

        private string column_name = " ";

        public Form1()
        {
            InitializeComponent();
        }

        private void lekerdezesButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapterObject.SelectCommand = new SqlCommand("SELECT id" +
                    " AS ID, format(datum,'yyyy-MM-dd') AS Datum, opening AS Opening, high AS High," +
                    " low AS Low, closing AS Closing, volume AS Volume, adjclose AS AdjClose FROM Stockdata" +
                    " ORDER BY id", SqlConnectionObject);
                DataSetObject.Clear();
                SqlDataAdapterObject.Fill(DataSetObject);
                stockdataGridView.DataSource = DataSetObject.Tables[0];
                BindingSourceObject.DataSource = DataSetObject.Tables[0];
                SetColumnSizeOfDataGridView();
                RecordNumbers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Lekérdezési hiba",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RecordNumbers()
        {
            if (BindingSourceObject.Count != 0)
            {
                rekordokSzamaLabel.Text
                = "" + (BindingSourceObject.Count);
            }
        }

        private void SetColumnSizeOfDataGridView()
        {
            stockdataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            stockdataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            stockdataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            stockdataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            stockdataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            stockdataGridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            stockdataGridView.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            stockdataGridView.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void setEmptyStringTextBoxes()
        {
            dateTextBox.Text = "";
            openTextBox.Text = "";
            highTextBox.Text = "";
            lowTextBox.Text = "";
            closeTextBox.Text = "";
            volumeTextBox.Text = "";
            adjcloseTextBox.Text = "";
        }

        private void stockdataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (BindingSourceObject.Position == 0)
                {
                    return;
                }
                else
                {
                    BindingSourceObject.MovePrevious();
                    RecordNumbers();
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (BindingSourceObject.Position ==
                    BindingSourceObject.Count - 1)
                {
                    return;
                }
                else
                {
                    BindingSourceObject.MoveNext();
                    RecordNumbers();
                }
            }
        }

        private void torlesButton_Click(object sender, EventArgs e)
        {
            int numberOfDelete = 0;
            try
            {
                DialogResult dr;
                dr = MessageBox.Show("Biztos benne?\nKésőbb, már nem vonható vissza a törlés",
                    "Törlés megerősítése",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    SqlConnectionObject.Open();
                    for (int i = 0; i < stockdataGridView.SelectedRows.Count; i++)
                    {
                        SqlDataAdapterObject.DeleteCommand = new SqlCommand("DELETE FROM Stockdata WHERE id = @ID",
                            SqlConnectionObject);
                        SqlDataAdapterObject.DeleteCommand.Parameters.Add("@ID", SqlDbType.Int).Value
                            = DataSetObject.Tables[0].Rows[this.stockdataGridView.SelectedRows[i].Index][0];
                        SqlDataAdapterObject.DeleteCommand.ExecuteNonQuery();
                        numberOfDelete++;
                    }
                    MessageBox.Show(numberOfDelete.ToString() + " sor törölve.",
                        "Törlés eredménye", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    DataSetObject.Clear();
                    SqlDataAdapterObject.Fill(DataSetObject);
                }
                else
                {
                    MessageBox.Show("Törlés visszavonva.", "Információ",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Törlési probléma",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SqlConnectionObject.Close();
            }
        }

        private void szerkesztesButton_Click(object sender, EventArgs e)
        {
            try
            {
                torlesButton.Enabled = false;                
                dateTextBox.DataBindings.Add
                (new Binding("Text", BindingSourceObject, "Datum"));
                openTextBox.DataBindings.Add
                (new Binding("Text", BindingSourceObject, "Opening"));
                highTextBox.DataBindings.Add
                (new Binding("Text", BindingSourceObject, "High"));
                lowTextBox.DataBindings.Add
                (new Binding("Text", BindingSourceObject, "Low"));
                closeTextBox.DataBindings.Add
                (new Binding("Text", BindingSourceObject, "Closing"));
                volumeTextBox.DataBindings.Add
                (new Binding("Text", BindingSourceObject, "Volume"));
                adjcloseTextBox.DataBindings.Add
                (new Binding("Text", BindingSourceObject, "AdjClose"));              
                mentesButton.Enabled = true;
                BindingSourceObject.Position =
                    stockdataGridView.CurrentRow.Index;
                RecordNumbers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),
                    "Szerkesztési hiba", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void mentesButton_Click(object sender, EventArgs e)
        {
            int numberOfUpdatedRows;
            try
            {
                SqlDataAdapterObject.UpdateCommand =
                    new SqlCommand("UPDATE Stockdata SET "
                    + "datum = @Datum, opening = @Opening, "
                    + "high = @High, "
                    + "low = @Low, "
                    + "closing = @Closing, "
                    + "volume = @Volume, "
                    + "adjclose = @AdjClose "
                    + "WHERE id = @ID", SqlConnectionObject);
                SqlDataAdapterObject.UpdateCommand.Parameters.Add
                    ("@Datum", SqlDbType.Date).Value = dateTextBox.Text;
                DateTime.ParseExact((dateTextBox.Text).Trim(), "yyyy-MM-dd", CultureInfo.GetCultureInfo("hu-HU"));
                SqlDataAdapterObject.UpdateCommand.Parameters.Add
                    ("@Opening", SqlDbType.Float).Value = openTextBox.Text;
                SqlDataAdapterObject.UpdateCommand.Parameters.Add
                    ("@High", SqlDbType.Float).Value = highTextBox.Text;
                SqlDataAdapterObject.UpdateCommand.Parameters.Add
                    ("@Low", SqlDbType.Float).Value = lowTextBox.Text;
                SqlDataAdapterObject.UpdateCommand.Parameters.Add
                    ("@Closing", SqlDbType.Float).Value = closeTextBox.Text;
                SqlDataAdapterObject.UpdateCommand.Parameters.Add
                    ("@Volume", SqlDbType.Int).Value = volumeTextBox.Text;
                SqlDataAdapterObject.UpdateCommand.Parameters.Add
                    ("@AdjClose", SqlDbType.Float).Value = adjcloseTextBox.Text;
                SqlDataAdapterObject.UpdateCommand.Parameters.Add
                    ("@ID", SqlDbType.Int).Value =
                    DataSetObject.Tables[0].Rows[stockdataGridView.
                    CurrentRow.Index][0];
                SqlConnectionObject.Open();
                numberOfUpdatedRows =
                    SqlDataAdapterObject.UpdateCommand.ExecuteNonQuery();
                if (numberOfUpdatedRows >= 1)
                {
                    MessageBox.Show(numberOfUpdatedRows.ToString() + " sor(ok) frissítve",
                        "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                RecordNumbers();
                mentesButton.Enabled = false;
                stockdataGridView.Refresh();

                setEmptyStringTextBoxes();

                torlesButton.Enabled = true;

                dateTextBox.DataBindings.Clear();
                openTextBox.DataBindings.Clear();
                highTextBox.DataBindings.Clear();
                lowTextBox.DataBindings.Clear();
                closeTextBox.DataBindings.Clear();
                volumeTextBox.DataBindings.Clear();
                adjcloseTextBox.DataBindings.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),
                    "Frissítés hiba", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                SqlConnectionObject.Close();
            }
        }

        private void hozzaadasButton_Click(object sender, EventArgs e)
        {

            if (dateTextBox.Text != "" && lowTextBox.Text != "" && volumeTextBox.Text != "")
            {
                int numberOfInserted = 0;
                try
                {
                    SqlDataAdapterObject.SelectCommand = new SqlCommand("SELECT id" +
                        " AS ID, format(datum,'yyyy-MM-dd') AS Datum, opening AS Opening, high AS High," +
                        " low AS Low, closing AS Closing, volume AS Volume, adjclose AS AdjClose FROM Stockdata" +
                        " ORDER BY id", SqlConnectionObject);
                    DataSetObject.Clear();
                    SqlDataAdapterObject.Fill(DataSetObject);
                    stockdataGridView.DataSource = DataSetObject.Tables[0];
                    BindingSourceObject.DataSource = DataSetObject.Tables[0];
                    SetColumnSizeOfDataGridView();
                    RecordNumbers();               

                    SqlDataAdapterObject.InsertCommand = new SqlCommand("INSERT INTO " +
                        "Stockdata VALUES (@Datum, @Open, @High, @Low, @Close, @Volume, @AdjClose)",
                        SqlConnectionObject);
                    SqlDataAdapterObject.InsertCommand.Parameters.Add("@Datum",
                        SqlDbType.DateTime).Value = dateTextBox.Text;
                    DateTime.ParseExact((dateTextBox.Text).Trim(), "yyyy-MM-dd", CultureInfo.GetCultureInfo("hu-HU"));
                    SqlDataAdapterObject.InsertCommand.Parameters.Add("@Open",
                        SqlDbType.Float).Value = openTextBox.Text;
                    SqlDataAdapterObject.InsertCommand.Parameters.Add("@High",
                        SqlDbType.Float).Value = highTextBox.Text;
                    SqlDataAdapterObject.InsertCommand.Parameters.Add("@Low",
                        SqlDbType.Float).Value = lowTextBox.Text;
                    SqlDataAdapterObject.InsertCommand.Parameters.Add("@Close",
                        SqlDbType.Float).Value = closeTextBox.Text;
                    SqlDataAdapterObject.InsertCommand.Parameters.Add("@Volume",
                        SqlDbType.Int).Value = volumeTextBox.Text;
                    SqlDataAdapterObject.InsertCommand.Parameters.Add("@AdjClose",
                        SqlDbType.Float).Value = adjcloseTextBox.Text;

                    SqlConnectionObject.Open();
                    numberOfInserted = SqlDataAdapterObject.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show(numberOfInserted.ToString() + " sor beszúrva.",
                        "Beszúrási eredmény", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DataSetObject.Clear();
                    SqlDataAdapterObject.Fill(DataSetObject);

                    setEmptyStringTextBoxes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Lekérdezési hiba",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    SqlConnectionObject.Close();
                }
            }
            else
            {
                MessageBox.Show("Ne hagyja üresen a mezőket!", "Formátum hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mentesButton.Enabled = false;

            chart.ContextMenuStrip = contextMenuStrip1;
            chart.Series.Clear();
        }

        private void szukitesButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> Adatok = new Dictionary<string, string>()
                {

                { "ID", "id"},
                { "Datum", "datum"},
                { "Opening", "opening"},
                { "High", "high"},
                { "Low", "low"},
                { "Closing", "closing"},
                { "Volume", "volume"},
                { "AdjClose", "adjclose"}
             };
            try
            {
                SqlDataAdapterObject.SelectCommand = new SqlCommand("SELECT id" +
                                " AS ID, format(datum,'yyyy-MM-dd') AS Datum, opening AS Opening, high AS High," +
                                " low AS Low, closing AS Closing, volume AS Volume, adjclose AS AdjClose FROM Stockdata WHERE [" +
                            Adatok[ChoosedComboBox.SelectedItem.ToString()] + "]" + "LIKE '%" + keresettMinta.Text + "%'", SqlConnectionObject);

                //TÖBB SZAVAS KERESÉSI MINTA ÉRTELMEZÉSE
                //string s = keresettMinta.Text;
                //string[] relations = s.Split(' ');
                //if (relations.Length != 0)
                //{
                //    SqlDataAdapterObject.SelectCommand = new SqlCommand("SELECT id" +
                //            " AS ID, format(datum,'yyyy-MM-dd') AS Datum, opening AS Opening, high AS High," +
                //            " low AS Low, closing AS Closing, volume AS Volume, adjclose AS AdjClose FROM Stockdata WHERE [" +
                //        Adatok[ChoosedComboBox.SelectedItem.ToString()] + "]" +
                //        "LIKE '%" + keresettMinta.Text + "%'" + " or " + Adatok[ChoosedComboBox.SelectedItem.ToString()] + relations[0] + relations[1], SqlConnectionObject);
                //}
                //else
                //{
                //    SqlDataAdapterObject.SelectCommand = new SqlCommand("SELECT id" +
                //                " AS ID, format(datum,'yyyy-MM-dd') AS Datum, opening AS Opening, high AS High," +
                //                " low AS Low, closing AS Closing, volume AS Volume, adjclose AS AdjClose FROM Stockdata WHERE [" +
                //            Adatok[ChoosedComboBox.SelectedItem.ToString()] + "]" + "LIKE '%" + keresettMinta.Text + "%'", SqlConnectionObject);

                //}

                DataSetObject.Clear();
                SqlDataAdapterObject.Fill(DataSetObject);
                stockdataGridView.DataSource = DataSetObject.Tables[0];
                BindingSourceObject.DataSource = DataSetObject.Tables[0];
                SetColumnSizeOfDataGridView();
                RecordNumbers();
                stockdataGridView.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Filter Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void chart_load(String column, String no_column)
        {
            if (stockdataGridView.DataSource == null)
                chart.Series.Clear();
            else
            {
                // Chart series hozzáadás
                chart.Series.Add(column);
                chart.DataSource = DataSetObject;
                chart.Series[column].XValueMember = "1";
                chart.Series[column].YValueMembers = no_column;
                chart.Series[column].IsValueShownAsLabel = true;
                switch (column)
                {
                    case "Opening":
                        chart.Series[column].ChartType = SeriesChartType.SplineRange;
                        break;

                    case "High":
                        chart.Series[column].ChartType = SeriesChartType.Point;
                        chart.Series[column].Color = Color.Red;
                        break;

                    case "Low":
                        chart.Series[column].ChartType = SeriesChartType.BoxPlot;
                        chart.Series[column].Color = Color.Blue;
                        break;

                    case "Closing":
                        chart.Series[column].ChartType = SeriesChartType.FastLine;
                        chart.Series[column].Color = Color.DarkGoldenrod;
                        break;

                    case "Volume":
                        chart.Series[column].ChartType = SeriesChartType.Area;
                        chart.Series[column].Color = Color.Khaki;
                        break;

                    case "AdjClose":
                        chart.Series[column].ChartType = SeriesChartType.Line;
                        chart.Series[column].Color = Color.Green;
                        break;
                }
                chart.DataBind();
            }
        }

        public void chart_series_select()
        {
            int index = 0;
            string column = " ";

            //chart.Series.Clear();

            // Checked item indexe
            foreach (int indexChecked in checkedListBox1.CheckedIndices)
            {
                index = indexChecked;
            }

            index+=2;

            // Checked item neve
            foreach (object itemChecked in checkedListBox1.CheckedItems)
            {
                column = itemChecked.ToString();
            }

            if (chart.Series.IsUniqueName(column) == true)
            chart_load(column, index.ToString());
            column_name = column;
        }

        private void checkedListBox1_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (int i in checkedListBox1.CheckedIndices)
            {
                checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void megjelenitButton_Click(object sender, EventArgs e)
        {
            //chart.Series.Clear();
            contextMenuStrip1.Items[0].Enabled = true;
            chart_series_select();
        }

        private void diatorlesButton_Click(object sender, EventArgs e)
        {
            chart.Series.Clear();
        }
    
        public void picSave(string column_name)
        {
            string pic_date = System.DateTime.UtcNow.ToString();
            pic_date = pic_date.Replace(":", "");
            pic_date = pic_date.Replace(".", "");
            pic_date = pic_date.Replace(" ", "");
            pic_date = pic_date.Replace("/", "");
            pic_date = pic_date.Replace("\\", "");

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Png Image|*.Png";
            saveFileDialog1.Title = "Save Chart Image File";
            saveFileDialog1.FileName = column_name + "_" + pic_date;         
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {               
                // Kép mentése a választott fájlformátumba
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        chart.SaveImage(saveFileDialog1.FileName,
                           ChartImageFormat.Jpeg);
                        break;

                    case 2:
                        chart.SaveImage(saveFileDialog1.FileName,
                           ChartImageFormat.Bmp);
                        break;

                    case 3:
                        chart.SaveImage(saveFileDialog1.FileName,
                           ChartImageFormat.Png);
                        break;
                }               
            }
        }

        // Jobb klikk menüben, mentés kiválasztás esetén
        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //csak akkor ment, ha nem üres a diagram
            if (chart.Series.Count != 0) { picSave(column_name); } else contextMenuStrip1.Items[0].Enabled = false;
        }

        //EGY TOVÁBBI FUNKCIÓ ÖTLETÉNEK EGY PRÓBÁJA
        //public void Upload(string fileToUpload)
        //{
        //    try
        //    {
        //        FileInfo toUpload = new FileInfo(fileToUpload);
        //        FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://web-okt.duf.hu/" + toUpload.Name);
        //        request.Method = WebRequestMethods.Ftp.UploadFile;
        //        request.Credentials = new NetworkCredential("user", "password");
        //        Stream ftpStream = request.GetRequestStream();
        //        FileStream file = File.OpenRead(fileToUpload);
        //        int length = 1024;
        //        byte[] buffer = new byte[length];
        //        int bytesRead = 0;
        //        do
        //        {
        //            bytesRead = file.Read(buffer, 0, length);
        //            ftpStream.Write(buffer, 0, bytesRead);
        //        }
        //        while (bytesRead != 0);
        //        file.Close();
        //        ftpStream.Close();
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Error connecting to server!");
        //    }
        //}
    }
}
