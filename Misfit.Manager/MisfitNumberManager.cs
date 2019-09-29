using System;
using Misfit.Data;

namespace Misfit.Manager
{
    
    public class MisfitNumberManager : IMisfitNumberManager
    {
        private IMisfitNumberRepository _MisfitNumberRepository;
        public MisfitNumberManager(IMisfitNumberRepository misfitNumberRepository)
        {
            _MisfitNumberRepository = misfitNumberRepository;
        }

        public int Add(int a, int b)
        {
            return _MisfitNumberRepository.Add(a, b);
        }
    }
}
