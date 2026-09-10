using Composite;

var root = new Folder("Root");

var documents = new Folder("Documents");
documents.Add(new Files("Resume.docx"));
documents.Add(new Files("CoverLetter.docx"));
root.Add(documents);


var images = new Folder("Images");
images.Add(new Files("Photo1.jpg"));
root.Add(images);

root.Display();