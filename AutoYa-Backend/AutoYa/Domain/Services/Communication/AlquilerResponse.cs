﻿using AutoYa_Backend.AutoYa.Domain.Models;
using AutoYa_Backend.Shared.Domain.Services.Communication;

namespace AutoYa_Backend.AutoYa.Domain.Services.Communication;

public class AlquilerResponse : BaseResponse<Alquiler>
{
    public AlquilerResponse(string message) : base(message)
    {
    }

    public AlquilerResponse(Alquiler resource) : base(resource)
    {
    }
}