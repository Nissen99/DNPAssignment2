﻿using System.Threading.Tasks;
using SimpleLogin.Models;

namespace SimpleLogin.BuisnessModels.FamilyModel
{
    public interface IPetModel
    {
        Task RemovePetAsync(Family family, Pet pet);
          Task<Pet> AddPetAsync(Pet pet);
    }
}