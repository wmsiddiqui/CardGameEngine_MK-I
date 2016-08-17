using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCardClasses.Buffs
{
    internal sealed class AppliedBuffs
    {
        //TODO: Create a singleton class which contains list of child buffs.
        //      To add, check if instance of childbuff exists in list.
        //      Is this doable? Performance hits: Reflection & transversal
        //      as numbersof buffs grow, so will the time to find the elements.
        //      However, with even a list of 1000, the transversal shouldn't be bad,
        //      worry about reflection and do-ability first. This will be a psudo factory.

        //#region Singleton Pattern
        //private static AppliedBuffs _instance;

        //public static AppliedBuffs AppliedBuffsProcessor
        //{
        //    get
        //    {
        //        if (_instance == null)
        //            _instance = new AppliedBuffs();
        //        return _instance;
        //    }
        //}

        //private AppliedBuffs()
        //{
        //    AppliedInGameBuffs = new List<Applied_Buffs.BuffBase>();
        //}
        //#endregion

        //private List<Applied_Buffs.BuffBase> AppliedInGameBuffs;

        //public void ApplyBuff(Applied_Buffs.BuffBase buff)
        //{
        //    //NEED TO UNBOX WITH REFLECTION, we could alternatively use IDs.
        //    //if
        //}
    }
}
