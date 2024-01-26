
using Core.Entities;
using Core.Helper;
using System.Xml.Schema;

Book book1 = new("Title1","Author1",1991);
Book book2 = new("Title2","Author2",1992);

book1.DeconstructRecord();
book2.DeconstructRecord();


Console.WriteLine(book1==book2);