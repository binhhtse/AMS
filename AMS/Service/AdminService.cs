﻿using AMS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AMS.Service
{
    public class AdminService
    {
        GenericRepository<House> allHouseInfo = new GenericRepository<House>();
        
        // get house's info
        // return list house's info
        public List<House> getAllHouseInfo()
        {
            return allHouseInfo.List.ToList();
        }
        #region add House
        //add House
        public void addHouse(String Block, String Floor, String HouseName, String Description, float Area)
        {
            House house = new House();
            house.Block = Block;
            house.Floor = Floor;
            house.HouseName = HouseName;
            house.Description = Description;
            house.Area = Area;

            allHouseInfo.Add(house);    //Add to house object
        }

        #endregion
        //public AdminService FindById(int Id)
        //{
        //    var result = allHouseInfo.FindById(Id);
        //    return result;
        //}
       
       
        #region delete House
        //delete House  
        public void deleteHouse(int Id)
        {
            House deleteHouse = new House();
            deleteHouse.Id = Id;
            allHouseInfo.Delete(allHouseInfo.FindById(deleteHouse.Id));
        }
        #endregion
        #region update House
        //update House
        public String updateHouse(int Id, String HouseName, String Description)
        {
            //    House house = new House();
            //    //allHouseInfo.List.ToList<Id>;
            //    house = allHouseInfo.FindById(house.Id);
            //    house.Id = Id;

            //    house.HouseName = HouseName;
            //    house.Description = Description;

            //    allHouseInfo.Update(house);
            //  //  allHouseInfo.Update(allHouseInfo.FindById(house.Id));
            bool isValid = true;
            isValid = !HouseName.Equals("");

            House house = new House();
            house.Id = Id;
            house = allHouseInfo.FindById(house.Id);
            if (house != null && isValid == true)
            {
                house.HouseName = HouseName;
                house.Description = Description;
                allHouseInfo.Update(house);
               return  "success update House" ;
               // return RedirectToAction("ManageHouse");
            }
            else
            {
                return "Can not update! ";
            }

          //  return "Update failed";
        }
        #endregion

        #region update House 2
        public String updateHouse2(int Id,String HouseName, String Description)
        {
            bool isValid = true;
            House house = new House();
            house = allHouseInfo.FindById(house.Id);
            house.Id = Id;
            if (house != null && isValid == true)
            {
                house.HouseName = HouseName;
                house.Description = Description;
                allHouseInfo.Update(house);
               return  "success update House" ;
               // return RedirectToAction("ManageHouse");
            }
            else
            {
                return "Can not update! ";
            }
        }
        #endregion
    }

    
}