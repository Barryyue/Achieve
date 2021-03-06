﻿using AchieveCommon;
using AchieveDALFactory;
using AchieveEntity;
using AchieveInterfaceDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AchieveBLL
{
    public class Sys_ModuleBLL
    {
        ISys_ModuleDAL dal = DALFactory.GetModuleDAL();

        /// <summary>
        /// 获取菜单
        /// </summary>
        public List<Sys_Module> GetAllModule()
        {
            return dal.GetAllModule();
        }
        /// <summary>
        /// 获取所有菜单
        /// </summary>
        /// <returns></returns>
        public List<Sys_Module> GetList()
        {
            return dal.GetList();
        }

        /// <summary>
        /// 根据角色获取菜单
        /// </summary>
        /// <returns></returns>
        public List<Sys_Module> GetMRoleList(string roleid)
        {
            return dal.GetMRoleList(roleid);
        }

        public Sys_Module GetForm(string id)
        {
            return dal.GetForm(id);
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <returns></returns>
        public bool Add(Sys_Module obj, string[] disstr = null)
        {
            return dal.Add(obj, disstr);
        }
        public bool Delete(string idstr)
        {
            return dal.Delete(idstr);
        }
        public bool Update(Sys_Module obj, string[] disablestr = null)
        {
            return dal.Update(obj, disablestr);
        }
    }
}
