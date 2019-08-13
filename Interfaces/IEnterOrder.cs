//NOTE: Interfaces are contracts that enforce a class has certain methods or properties
//NOTE: Interfaces do not contain a constructor
//NOTE: All interfaces naming convention start with 'I'
namespace InterfaceDiner.Interfaces
{
    interface IEnterOrder
    {
        //NOTE ALL methods and properties of an Interface are public and CANNOT be private
        float MaxDiscount { get; set; }

        //NOTE NO METHOD IS DEFINED OTHER THAN ITS SIGNATURE (POLYMORPHISM)
        void EnterOrder();
    }




    //NOTE EXAMPLE OF POLYMORPHISM

    interface ILight
    {

        // Light Illuminate(Electricty power);
    }
}
