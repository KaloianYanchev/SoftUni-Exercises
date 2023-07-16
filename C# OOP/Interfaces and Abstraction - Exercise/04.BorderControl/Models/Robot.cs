using BorderControl.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl.Models
{
    public class Robot : IIdentifiable
    {
        private string _model;
        private string _id;

        public Robot(string model, string id)
        {
            Model = model;
            Id = id;
        }

        public string Model { get => _model; private set => _model = value; }

        public string Id { get => _id; private set => _id = value; }
    }
}