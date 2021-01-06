using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest2
    {
        // As a developer, i want the ability to remove an object from an instance of my custom-built list class by imitating the C# Remove() method.
        //-----
        
        [TestMethod]
        public void CustomRemoveMethod_RemoveFirstItemInList_NullOrZero() // 1. remove item and check that item was removed
        {

        }
        [TestMethod]
        public void CustomRemoveMethod_CheckIndexValuesAfterItemRemoved_IndexOneEqualIndexZero() // 2. remove item and make sure that other items in list indexes change
        {

        }
        [TestMethod]
        public void CustomRemoveMethod__UpdateCountAfterRemove_CountEqaulsFour() // 3. if list count is 5 and item is removed, count should go to 4
        {

        }
        [TestMethod]
        public void CustomRemoveMethod__UpdateCapacityAfterRemove_CapacityEqaulsFour() // 4. make sure capacity changes if not needed after removing item
        {

        }
        [TestMethod]
        public void CustomRemoveMethod_IsThereAnItemToRemove_ReturnFalse() // 5. check to see if there is an item to remove from list
        {

        }
    }
}
