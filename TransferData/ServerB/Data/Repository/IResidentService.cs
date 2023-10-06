﻿using System.Collections.Generic;
using System.Threading.Tasks;
using ServerB.Data.Models;

namespace ServerB.Data.Repository
{
	public interface IResidentService
	{
        Task<List<Resident>> GetDataResidentsServerA();
        Task<List<Resident>> GetDataResidentsServerB();
        Task SyncData();
    }
}

