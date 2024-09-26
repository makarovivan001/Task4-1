using System;
namespace HomeWork_Makarov_Ivan_number_3._1
{
	public abstract class BaseArray<T> : IBaseArray<T>
	{


        protected ValueProvider<T> Provider;
        public abstract void Print();
        


    }
}

