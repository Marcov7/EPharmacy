using OfficeOpenXml;
using System.IO;
using System.Windows.Forms;

public class ExportExcel
{

    public ExportExcel()
    {
        // Licença para o ExportDataGrid para o Excel
        Environment.SetEnvironmentVariable("EPPlusLicenseContext", "NonCommercial", EnvironmentVariableTarget.Process);
    }


    public static string ExportDataGridViewToExcel(DataGridView dgv, string filePath, string path)
    {
        Environment.SetEnvironmentVariable("EPPlusLicenseContext", "NonCommercial", EnvironmentVariableTarget.Process);

        try
        {
            // Cria um novo arquivo Excel
            using (var package = new ExcelPackage())
            {
                // Adiciona uma nova planilha
                var worksheet = package.Workbook.Worksheets.Add("Sheet1");

                // Adiciona cabeçalhos de coluna
                for (int col = 0; col < dgv.Columns.Count; col++)
                {
                    worksheet.Cells[1, col + 1].Value = dgv.Columns[col].HeaderText;
                }

                // Adiciona os dados do DataGridView
                for (int row = 0; row < dgv.Rows.Count; row++)
                {
                    for (int col = 0; col < dgv.Columns.Count; col++)
                    {
                        if (dgv.Rows[row].Cells[col].Value != null)
                        {
                            worksheet.Cells[row + 2, col + 1].Value = dgv.Rows[row].Cells[col].Value.ToString();
                        }
                    }
                }

                // Salva o arquivo Excel no caminho especificado
                FileInfo fi = new FileInfo(path + filePath);
                package.SaveAs(fi);
            }

            return "Arquivo Excel exportado com sucesso!";
        }
        catch (Exception ex)
        {
            return "Erro na geraçã do Arquivo Excel. Não exportado!";
        }
    }
}