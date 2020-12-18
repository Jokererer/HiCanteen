﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi食堂.dao;
using Hi食堂.entity;

namespace Hi食堂.service
{
    class SysAdmiService
    {
        DataBase db = new DataBase();
        SystemAdmi sys = new SystemAdmi();
        SystemAdmiDao sysDao = new SystemAdmiDao();
        MerchantAdmi merAdmi = new MerchantAdmi();
        MerchantAdmiDao merAdmiDao = new MerchantAdmiDao();

        public int login(int id, string pwd)
        {
            sys.setAdmiID(id);
            sys.setAdmiPasswd(pwd);
            DataTable dt = sysDao.findSysAdmi(sys);
            if (dt.Rows.Count == 0)  //管理员账号错误
            {
                return -1;
            }
            //验证密码
            else if (dt.Rows[0][1].ToString() != pwd)//密码错误
            {
                return -2;
            }
            else   //登录成功
            {
                return 1;
            }
        }

        public bool addMerAdmi(string pwd,string canteen) //添加商家管理员
        {
            merAdmi.setMerchantAdmiPasswd(pwd);
            merAdmi.setCanteenName(canteen);
            bool flag = merAdmiDao.addMerchantAdmi(merAdmi);
            return flag;        
        }
        public bool updateCan(int id,string canteen)  //更改商家所管食堂
        {
            merAdmi.setMerchantAdmiID(id);
            DataTable dt = merAdmiDao.findMerAdmi(id);
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                bool f = merAdmiDao.updateMerchantAdmiCanteen(id, canteen);
                return f;
            }
        }

        public bool updatePwd(int id,string pwd)  //更改商家管理员密码
        {
            //merAdmi.setMerchantAdmiID(id);
            DataTable dt = merAdmiDao.findMerAdmi(id);
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                bool f = merAdmiDao.updateMerchantAdmiPasswd(id, pwd);
                return f;
            }
        }

        //查看所有商家管理员
        public DataTable showAllMerAdmi() 
        {
            string sql = "select * from merchantadmi";
            DataTable dt = db.QueryData(sql);
            return dt;
        }
        //查看单个商家管理员
        public DataTable showOneMerAdmi(int id)
        {
            DataTable dt = showAllMerAdmi();
            DataTable res = dt.Clone();//定义表res，用来存储查询数据（res克隆了dt表的架构与约束）
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][0].Equals(id))
                {

                    res.ImportRow(dt.Rows[i]); //将符合条件的行添加到结果表中
                }
            }
            return res;
        }
        //查看所有商家信息
        public DataTable showAllMer()  
        {
            string sql = "select * from merchant";
            DataTable dt = db.QueryData(sql);
            return dt;
        }
        //用id来查商家信息
        public DataTable showOneMer(int id)   
        {
            DataTable dt = showAllMer();
            DataTable res = dt.Clone();
            //DataRow[] data = dt.Select()
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][0].Equals(id))
                {
                    
                    res.ImportRow(dt.Rows[i]); //将符合条件的行添加到结果表中
                }
            }
            return res;
        }
        
        //查看所有顾客信息
        public DataTable showAllCustoms()  
        {
            string sql = "select * from customer";
            DataTable dt = db.QueryData(sql);
            return dt;
        }
        //按照账号查看顾客信息
        public DataTable showOneCustomID(int id)  
        {
            DataTable dt = showAllCustoms();
            DataTable res = dt.Clone();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][0].Equals(id))
                {

                    res.ImportRow(dt.Rows[i]); //将符合条件的行添加到结果表中
                }
            }
            return res;
        }
        //按照电话号码查询顾客信息
        public DataTable showOneCustomPh(string phone) 
        {
            DataTable dt = showAllCustoms();
            DataTable res = dt.Clone();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][4].Equals(phone))
                {

                    res.ImportRow(dt.Rows[i]); //将符合条件的行添加到结果表中
                }
            }
            return res;
        }

        //查看所有订单信息
        public DataTable showAllOrders()  
        {
            string sql = "select * from orders";
            DataTable dt = db.QueryData(sql);
            return dt;
        }
        //查看单条订单信息（根据订单ID查找））
        public DataTable showOneOrder(int id)
        {
            DataTable dt = showAllOrders();
            DataTable res = dt.Clone();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][0].Equals(id))
                {

                    res.ImportRow(dt.Rows[i]); //将符合条件的行添加到结果表中
                }
            }
            return res;
        }
        //查看单个商家的订单信息（按照商家ID来查）
        public DataTable showMerOrders(int id)
        {
            DataTable dt = showAllOrders();
            DataTable res = dt.Clone();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][2].Equals(id))
                {

                    res.ImportRow(dt.Rows[i]); //将符合条件的行添加到结果表中
                }
            }
            return res;
        }
        //查看某个顾客的订单信息（按照顾客ID查看）
        public DataTable showCusOrders(int id)
        {
            DataTable dt = showAllOrders();
            DataTable res = dt.Clone();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][1].Equals(id))
                {

                    res.ImportRow(dt.Rows[i]); //将符合条件的行添加到结果表中
                }
            }
            return res;
        }
    }
}