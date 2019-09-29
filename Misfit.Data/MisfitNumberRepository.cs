using System;
namespace Misfit.Data
{
    public class MisfitNumberRepository : IMisfitNumberRepository
    {
        public MisfitNumberRepository()
        {
        }

        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
