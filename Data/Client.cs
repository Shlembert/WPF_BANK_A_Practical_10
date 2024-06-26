﻿using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Wpf_Bank_A.Data
{
    public class Client
    {
        [DataMember]
        public string FullName { get; set; }
        [DataMember]
        public string PhoneNumber { get; set; }
        [DataMember]
        public string PassportSeries { get; set; }
        [DataMember]
        public string PassportNumber { get; set; }
        [DataMember]
        public DateTime CreatedDateTime { get; set; }
        [DataMember]
        public DateTime LastModificationDateTime { get; set; }
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public ModificationType ModificationType { get; set; }
        [DataMember]
        private static int nextId = 1;

        public Client(string fullName, string phoneNumber, string passportSeries, string passportNumber, ModificationType modificationType)
        {
            Id = nextId++;
            FullName = fullName;
            PhoneNumber = phoneNumber;
            PassportSeries = passportSeries;
            PassportNumber = passportNumber;
            ModificationType = modificationType;
            CreatedDateTime = DateTime.Now;
            LastModificationDateTime = CreatedDateTime;
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static Client FromJson(string json)
        {
            return JsonConvert.DeserializeObject<Client>(json);
        }
    }

    public enum ModificationType
    {
        Консультант,
        Менеджер
    }
}

