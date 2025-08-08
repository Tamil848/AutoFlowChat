using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowChart3Excel
{
    public class ReadExcel
    {
        public List<FlowStep> ReadFlowStepsFromExcel(string filePath)
        {
            
            var steps = new List<FlowStep>();
            try
            {
                using var workbook = new XLWorkbook(filePath);
                var worksheet = workbook.Worksheet(1);

                var rows = worksheet.RangeUsed().RowsUsed().Skip(1); // skip header

                foreach (var row in rows)
                {
                    var step = new FlowStep
                    {
                        Id = row.Cell(1).GetString(),
                        Text = row.Cell(2).GetString(),
                        Type = row.Cell(3).GetString(),
                        Next = row.Cell(4).GetString().Split(',', StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList()
                    };

                    steps.Add(step);
                }
            }
            catch(Exception ex)
            {

            }

            return steps;
        }
    }
}
