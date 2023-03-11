using EnkaSharp.Models;

namespace EnkaSharp.Repository;

public interface IEnkaRepository
{
    public Task<Info> Info(long uid);
}