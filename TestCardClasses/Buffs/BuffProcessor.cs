﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCardClasses.Buffs.Applied_Buffs;

namespace TestCardClasses.Buffs
{
    public static class BuffProcessor
    {
        public static void AddBuff(BuffBase buff, BaseUnit unit)
        {
            if(!buff.Stackable)
            {
                var matchingBuffs = FindMatchingAppliedBuffs(buff, unit);
                if (matchingBuffs != null)
                {
                    if (matchingBuffs.Count() > 1)
                        throw new Exception("More than one of the same non-stackable buffs applied!");

                    var matchedBuff = matchingBuffs.First();
                    unit.AppliedBuffs.Remove(matchedBuff);
                }               
            }            
            unit.AppliedBuffs.Add(buff);
            buff.ParentUnit = unit;
        }
        /// <summary>
        /// Removes first occurance of specified buff from unit.
        /// If removeAll is true, all instances of buff are removed.
        /// </summary>
        /// <param name="buff">The buff to be removed</param>
        /// <param name="unit">The Unit the buff will be removed from</param>
        /// <param name="removeAll">Will all instnaces of the buff be removed?</param>
        public static void RemoveBuff(BuffBase buff, BaseUnit unit, bool removeAll = false)
        {
            var matchingBuffs = FindMatchingAppliedBuffs(buff, unit);
            if (matchingBuffs == null)
            {
                throw new Exception("No buff found for unit!");
            }

            if (removeAll)
            {
                unit.AppliedBuffs.RemoveAll(b => b.GetType() == buff.GetType());
            }
            else
            {
                var first = unit.AppliedBuffs.First(b => b.GetType() == buff.GetType());
                unit.AppliedBuffs.Remove(first);
            }
        }
        private static IEnumerable<BuffBase> FindMatchingAppliedBuffs(BuffBase buff, BaseUnit unit)
        {
            var matchingBuffs = unit.AppliedBuffs.Where(b => b.GetType() == buff.GetType());

            if (matchingBuffs.Count() > 0)
            {
                return matchingBuffs;
            }
            return null;
        }        

        public static void SetUnitHealth(BaseUnit unit, int health)
        {
            unit.Health = health;
        }

        public static bool DamageValid(BaseUnit defendingUnit, BaseUnit attackingUnit)
        {
            return true;
        }
    }
}