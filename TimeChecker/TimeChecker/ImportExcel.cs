using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
// Objetos de Excel
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using System.Security.Permissions;
using System.Security;

namespace TimeChecker
{
    class ImportExcel
    {
        Schedule auxSch;
        string[,] auxStr;
        string[] days = { "B", "C", "D", "E", "F", "G", "H" };
        // Objetos de Excel
        Excel.Application xlApp;
        Excel.Workbook xlWorkBook;
        Excel.Worksheet xlWorkSheet;
        object misValue = System.Reflection.Missing.Value;
        String route = "";

        public void generateExcel(string person)
        {
            string strPathToResource = @"c:\SCHTemplate.xlsx";
            try
            {
                xlApp = new Excel.Application();
                Excel.Workbook wbTarget;

                // Nuevo horario a partir de plantilla
                using (FileStream cFileStream = new FileStream(strPathToResource, FileMode.Create))
                {
                    cFileStream.Write(Properties.Resources.schtmp, 0, Properties.Resources.schtmp.Length);
                }

                wbTarget = xlApp.Workbooks.Open(strPathToResource);
                xlWorkSheet = wbTarget.Worksheets.get_Item(1);
                xlWorkSheet.Cells[1, 2] = person;
                xlWorkSheet.Name = "Horario de " + person;

                // Guardando Horario
                wbTarget.SaveAs(@"c:\Horario de " + person + ".xlsx", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing,
                false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                wbTarget.Close();
                xlApp.Quit();
                System.IO.File.Delete(strPathToResource);

                MessageBox.Show("Tu Horario está en el disco C:", "Éxito");
            } catch (Exception ex) {
                MessageBox.Show(/*ex.ToString()*/"Ha ocurrido un error.", "Error");
                xlApp.Quit();
                System.IO.File.Delete(strPathToResource);
            }
        }

        public void importExcel(ref List<Schedule> teamList)
        {
            auxSch = new Schedule();
            xlApp = new Excel.Application();
            try
            {
                OpenFileDialog openfile1 = new OpenFileDialog();
                openfile1.Filter = "Excel Files |*.xlsx";
                openfile1.Title = "Seleccione archivo de Excel";
                if (openfile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openfile1.FileName.Equals("") == false)
                    {
                        route = openfile1.FileName;
                    }
                }

                // Abriendo documento y hoja
                xlWorkBook = xlApp.Workbooks.Open(route);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                // Inicializando variables auxiliares
                auxSch = new Schedule();
                auxStr = new string [34, 7];

                // Obteniendo Nombre y Horario
                auxSch.person = xlWorkSheet.Cells[1, 2].Value;

                for (int j = 0; j < 7; j++) {
                    for (int i = 4; i < 38; i++) {
                        string aux = days[j] + i.ToString();
                        // MessageBox.Show(aux);
                        auxStr[i - 4, j] = System.Convert.ToString((xlWorkSheet.get_Range(aux).Value));
                        // MessageBox.Show(personSched[i - 4, j]);
                    }
                }
                auxSch.wkSchd = auxStr;
                // Agregando el auxiliar a la lista
                teamList.Add(auxSch);
                
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                MessageBox.Show("Se ha agregado a " + auxSch.person + " a la lista","Éxito");
            } catch (Exception ex) {
                MessageBox.Show(ex.ToString(),"Error.");
                xlApp.Quit();
            }
        }

        public void generateShared(ref Stack<Schedule> stackMembers) {
            Schedule aux;
            string[,] sharedSched;
            string integ = "Grupo: ";
            string auxFilename = "SCHTemplate.xlsx";
            string datapath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string auxFile = Path.Combine(datapath, auxFilename);
            
            
            
            Excel.Workbook wbTarget;
            xlApp = new Excel.Application();

            // Nuevo horario a partir de plantilla
            using (FileStream cFileStream = new FileStream(auxFile, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                cFileStream.Write(Properties.Resources.schtmp, 0, Properties.Resources.schtmp.Length);
            }

            wbTarget = xlApp.Workbooks.Open(auxFile);
            xlWorkSheet = wbTarget.Worksheets.get_Item(1);
                

            try
            {
               
                // Generando Horario Compartido de Grupo
                sharedSched = new string[34, 7];
                while (stackMembers.Count > 0) {
                    aux = stackMembers.Pop();
                    // sharedSched += aux.wkSchd;
                    for (int j = 0; j < 7; j++)
                    {
                        for (int i = 0; i < 34; i++)
                        {
                            if (aux.wkSchd[i, j] == "x")
                            {
                                sharedSched[i, j] = "x";
                            }
                        }
                    }
                    integ += aux.person + ", ";
                }

                // Agregando el Horario Compartido al Excel
                for (int j = 2; j < 9; j++)
                {
                    for (int i = 4; i < 38; i++)
                    {
                        xlWorkSheet.Cells[i, j] = sharedSched[i - 4, j - 2];   
                    }
                }
                xlWorkSheet.Cells[1, 2] = integ;

                string filename = "Compartido del Grupo.xlsx";

                xlWorkSheet.Name = "HorarioCompartidodelGrupo";

                string appFile = Path.Combine(datapath, filename);

                // Guardando Horario Compartido
                wbTarget.SaveAs(appFile, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing,
                false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                wbTarget.Close();
                xlApp.Quit();
                System.IO.File.Delete(auxFile);

                MessageBox.Show("El Horario Compartido del Grupo está en el escritorio.", "Éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + " Ha ocurrido un error.", "Error");
                wbTarget.Close();
                xlApp.Quit();
                System.IO.File.Delete(auxFile);
            }
        }
    }
}
