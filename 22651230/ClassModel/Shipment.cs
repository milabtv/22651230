using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22651230.ClassModel
{
    public class Shipment
    {
        private int id;
        private Worker worker;
        private Client client;
        private Courier courier;
        private DateTime dateship;
        public List<ShipmentPackage> package = new List<ShipmentPackage> { };
        public Shipment()
        {
            
        }

        public Shipment(int id, Worker worker, Client client, Courier courier, DateTime dateship)
        {
            this.id = id;
            this.worker = worker;
            this.client = client;
            this.courier = courier;
            this.dateship = dateship;
        }

        public int Id { get => id; set => id = value; }
        public Worker Worker { get => worker; set => worker = value; }
        public Client Client { get => client; set => client = value; }
        public Courier Courier { get => courier; set => courier = value; }
        public DateTime Dateship { get => dateship; set => dateship = value; }

        public void PackageAdd(ShipmentPackage shipPack)
        {
            package.Add(shipPack);   
        }
        public void PackageRemove(ShipmentPackage shipPack)
        {
            package.Remove(shipPack);
        }
    }
}
