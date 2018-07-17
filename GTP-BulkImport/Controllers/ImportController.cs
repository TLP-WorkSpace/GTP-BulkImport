using GTP_BulkRepositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Npoi.Core.HSSF.UserModel;
using Npoi.Core.SS.UserModel;
using Npoi.Core.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace GTP_BulkImport.Controllers
{
    [Route("api/[controller]")]
    public class ImportController : Controller
    {
        protected IImportRepository Import;
        private IHostingEnvironment hostingEnv;

        public ImportController(IHostingEnvironment env, IImportRepository importRepository)
        {
            this.hostingEnv = env;
            Import = importRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("getword")]
        public string getword()
        {
            return "你好";
        }

        /// <summary>
        /// 导入
        /// </summary>
        /// <returns></returns>
        [HttpPost("ImportExcel")]
        public async Task ImportExcel()
        {
            var file = Request.Form.Files[0];
            var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            IWorkbook workbook;
            ISheet sheet = null;
            Queue<DriverVM> dt = new Queue<DriverVM>();
            int startRow = 1;
            MemoryStream stream = new MemoryStream();
            await file.CopyToAsync(stream);
            using (var fs = file.OpenReadStream())
            {
                if (fileName.IndexOf(".xlsx") > 0) // 2007版本
                    workbook = new XSSFWorkbook(fs);
                else if (fileName.IndexOf(".xls") > 0)   // 2003版本
                    workbook = new HSSFWorkbook(fs);
                else
                    throw new Exception("导入的文件格式有误只支持Excel2003和2007版本");
                var fileObj = new DriverVM();
                sheet = workbook.GetSheetAt(0);
                if (sheet != null)
                {
                    IRow firstRow = sheet.GetRow(0);
                    int cellCount = firstRow.LastCellNum; //一行最后一个cell的编号 即总的列数
                                                          //最后一列的标号
                    int rowCount = sheet.LastRowNum;
                    for (int i = startRow; i <= rowCount; ++i)
                    {
                        IRow row = sheet.GetRow(i);
                        if (row == null) continue; //没有数据的行默认是null　　　　　　　
                        DriverVM dataRow = new DriverVM();
                        for (int j = row.FirstCellNum; j < cellCount; ++j)
                        {
                            if (row.GetCell(j) != null) //同理，没有数据的单元格都默认是null
                            {
                                var values = row.GetCell(j).ToString();
                                try
                                {
                                    switch (j)
                                    {
                                        case 0:
                                            dataRow.UserName = values.Trim();
                                            break;
                                        case 1:
                                            dataRow.PhoneNumber = values.Trim();
                                            break;                                        
                                    }
                                }
                                catch (Exception ex)
                                {
                                    throw new Exception($"第{i + 1}行,第{j + 1}列数据有误，请检查！");
                                }
                            }
                        }
                        dt.Enqueue(dataRow);
                    }
                    stream.Dispose();
                    await Import.ImportExcel(dt);
                }
            }
        }
    }
}
