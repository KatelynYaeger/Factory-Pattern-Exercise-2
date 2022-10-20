using System;
namespace FactoryPatternExercise2
{
    public interface IDataAccess
    {

        public void Savedata();
        public List<Product> LoadData();

    }

}

