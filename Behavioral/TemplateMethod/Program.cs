using TemplateMethod;

DocumentProcessor pdfProcessor = new PdfProcessor();
pdfProcessor.ProcessDocument();

DocumentProcessor excelProcessor = new ExcelProcessor();
excelProcessor.ProcessDocument();