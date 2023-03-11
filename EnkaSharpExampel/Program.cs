using EnkaSharp.Repository;
using EnkaSharp.Service;

IEnkaRepository enka=new EnkaRepository("en");
var a = await enka.Info(743547342);
Console.WriteLine(a.Owner.Profile.Avatar);


