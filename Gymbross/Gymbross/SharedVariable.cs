﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymbross
{
    internal class SharedVariable
    {
        public static int Username;
        public static string? PassName;
        //addmember
        public static string? MemberName;
        public static string? PhoneNum;
        public static string? Age;
        public static string? Gender;
        public static int coachid;
        //viewlist
        public static string? Search;
        public static string? Refresh;
        //update
        public static int memid;
        public static string? contactinfo;
        public static string? MembernameD;
        public static string? PhonenumD;
        public static string? AgenameD;
        public static string? GenderD;
        public static string? MembershipTypeD;

        //Membership
        public static int MemId;
        public static string? Membershiptye;
        public static DateTime Enddate;
        public static string? SearchM;
        public static int membershipId;
        // Coach
        public static string? MembernameC;
        public static string? CoachC;

        // transaction
        public static double amounth;
        public static double Change;
        public static string? Paymenthod;
        public static double total;
        public static int memberidT;

        //Program 
        public static int categid;

        //Report
        public static string? RName;
        public static string? Rage;
        public static string? ContactNo;
        public static string? GenderR;
        public static int Rcoach;
        public static int Rid;

    }
}
