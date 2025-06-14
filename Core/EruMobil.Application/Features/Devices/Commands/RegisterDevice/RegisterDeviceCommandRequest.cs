﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EruMobil.Application.Features.Devices.Commands.RegisterDevice
{
    public class RegisterDeviceCommandRequest : IRequest<Unit>
    {
        public Guid UserId { get; set; } // Kullanıcının ID'si
        public string DeviceName { get; set; }
        public string UniqueDeviceIdentifier { get; set; }
        public string Platform { get; set; } // "android" veya "ios"
        public string FcmToken { get; set; }
        public string AppVersion { get; set; }
    }

    /*
     public class DeviceInfoDto
{
     public string DeviceName { get; set; }
    public string UniqueDeviceIdentifier { get; set; }
    public string Platform { get; set; } // "android" veya "ios"
    public string FcmToken { get; set; }
    public string AppVersion { get; set; }
   
}
     */
}
