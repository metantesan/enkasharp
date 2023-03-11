using EnkaSharp;
using EnkaSharp.Repository;
using EnkaSharp.Service;

IEnkaRepository enka=new EnkaRepository("en");
await enka.Info(743547342);