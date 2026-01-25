using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetManage.Dal.Entities;

namespace AssetManage.Dal.Seed
{
    public static class SeedData
    {
        public static List<Asset> GetAssets()
        {
            return
            [
                new Asset
                {
                    AssetTag = "BLDA-RTU-E-2016", 
                    Name = "Rooftop HVAC Unit – East Wing", 
                    Category = "HVAC",
                    Location = "Building A – Roof",
                    IsRetired = false
                },
                new Asset
                {
                    AssetTag = "BLDA-RTU-W-2014",
                    Name = "Rooftop HVAC Unit – West Wing", 
                    Category = "HVAC",
                    Location = "Building A – Roof", 
                    IsRetired = false
                },
                new Asset
                {
                    AssetTag = "BLDA-AHU-MECH1", 
                    Name = "Air Handling Unit – Mechanical Room 1", 
                    Category = "HVAC",
                    Location = "Building A – Mechanical Room", 
                    IsRetired = false
                },
                new Asset
                {
                    AssetTag = "BLDA-AHU-MECH2", 
                    Name = "Air Handling Unit – Mechanical Room 2", 
                    Category = "HVAC",
                    Location = "Building A – Mechanical Room", 
                    IsRetired = false
                },

                new Asset
                {
                    AssetTag = "BLDC-GEN-CAT-01",
                    Name = "Caterpillar Backup Generator", 
                    Category = "Power",
                    Location = "Building C – Generator Room", 
                    IsRetired = false
                },
                new Asset
                {
                    AssetTag = "BLDC-GEN-KOHLER-02", 
                    Name = "Kohler Backup Generator", 
                    Category = "Power",
                    Location = "Building C – Generator Room",
                    IsRetired = false
                },

                new Asset
                {
                    AssetTag = "BLDD-UPS-APC-R1",
                    Name = "APC UPS – Data Center Row 1",
                    Category = "Power",
                    Location = "Building D – Data Center",
                    IsRetired = false
                },
                new Asset
                {
                    AssetTag = "BLDD-UPS-APC-R2", 
                    Name = "APC UPS – Data Center Row 2", 
                    Category = "Power",
                    Location = "Building D – Data Center", 
                    IsRetired = false
                },

                new Asset
                {
                    AssetTag = "BLDD-PDU-EATON-A1", 
                    Name = "Eaton PDU – Rack A1", 
                    Category = "Power",
                    Location = "Building D – Server Room", 
                    IsRetired = false
                },
                new Asset
                {
                    AssetTag = "BLDD-PDU-EATON-B3",
                    Name = "Eaton PDU – Rack B3", 
                    Category = "Power",
                    Location = "Building D – Server Room", 
                    IsRetired = false
                },

                new Asset
                {
                    AssetTag = "BLDA-FIRE-SIMPLEX-CP", 
                    Name = "Simplex Fire Control Panel", 
                    Category = "Safety",
                    Location = "Building A – Fire Command Room", 
                    IsRetired = false
                },
                new Asset
                {
                    AssetTag = "BLDB-FIRE-HONEYWELL", 
                    Name = "Honeywell Fire Alarm Panel", 
                    Category = "Safety",
                    Location = "Building B – Security Office", 
                    IsRetired = false
                },

                new Asset
                {
                    AssetTag = "SITE-SEC-AXIS-P01", 
                    Name = "Axis Security Camera – Main Entrance",
                    Category = "Security", 
                    Location = "Building A – Lobby", 
                    IsRetired = false
                },
                new Asset
                {
                    AssetTag = "SITE-SEC-AXIS-P07", 
                    Name = "Axis Security Camera – Parking North",
                    Category = "Security", 
                    Location = "Parking Lot – North", 
                    IsRetired = false
                },
                new Asset
                {
                    AssetTag = "SITE-SEC-AXIS-P12",
                    Name = "Axis Security Camera – Parking South",
                    Category = "Security", 
                    Location = "Parking Lot – South", 
                    IsRetired = false
                },

                new Asset
                {
                    AssetTag = "BLDA-ACS-LENEL-01", 
                    Name = "Lenel Access Control Panel – East Wing",
                    Category = "Security", 
                    Location = "Building A – IDF Closet", 
                    IsRetired = false
                },
                new Asset
                {
                    AssetTag = "BLDB-ACS-LENEL-02", 
                    Name = "Lenel Access Control Panel – West Wing",
                    Category = "Security", 
                    Location = "Building B – IDF Closet", 
                    IsRetired = false
                },

                new Asset
                {
                    AssetTag = "BLDB-ELEV-OTIS-CAR1", 
                    Name = "Otis Elevator Controller – Car 1",
                    Category = "Vertical Transport", 
                    Location = "Building B – Elevator Shaft", 
                    IsRetired = false
                },
                new Asset
                {
                    AssetTag = "BLDB-ELEV-OTIS-CAR2", 
                    Name = "Otis Elevator Controller – Car 2",
                    Category = "Vertical Transport", 
                    Location = "Building B – Elevator Shaft", 
                    IsRetired = false
                },

                new Asset
                {
                    AssetTag = "BLDC-BOILER-CLEAVER", 
                    Name = "Cleaver-Brooks Boiler", 
                    Category = "Mechanical",
                    Location = "Building C – Boiler Room", 
                    IsRetired = false
                },
                new Asset
                {
                    AssetTag = "BLDC-BOILER-LOCHINVAR", 
                    Name = "Lochinvar Boiler", 
                    Category = "Mechanical",
                    Location = "Building C – Boiler Room", 
                    IsRetired = false
                },

                new Asset
                {
                    AssetTag = "BLDA-CHILL-TRANE-N", 
                    Name = "Trane Chiller – North Loop", 
                    Category = "Mechanical",
                    Location = "Building A – Chiller Yard", 
                    IsRetired = false
                },
                new Asset
                {
                    AssetTag = "BLDA-CHILL-TRANE-S", 
                    Name = "Trane Chiller – South Loop", 
                    Category = "Mechanical",
                    Location = "Building A – Chiller Yard", 
                    IsRetired = false
                },

                new Asset
                {
                    AssetTag = "BLDA-PUMP-GRUNDFOS-1", 
                    Name = "Grundfos Circulation Pump – Zone 1",
                    Category = "Plumbing", 
                    Location = "Building A – Pump Room", 
                    IsRetired = false
                },
                new Asset
                {
                    AssetTag = "BLDB-PUMP-GRUNDFOS-2", 
                    Name = "Grundfos Circulation Pump – Zone 2",
                    Category = "Plumbing", 
                    Location = "Building B – Pump Room", 
                    IsRetired = false
                },

                new Asset
                {
                    AssetTag = "BLDD-AIR-ATLAS-A", 
                    Name = "Atlas Copco Compressor – Line A", 
                    Category = "Utilities",
                    Location = "Building D – Utility Room", 
                    IsRetired = false
                },
                new Asset
                {
                    AssetTag = "BLDD-AIR-ATLAS-B", 
                    Name = "Atlas Copco Compressor – Line B", 
                    Category = "Utilities",
                    Location = "Building D – Utility Room", 
                    IsRetired = false
                },

                new Asset
                {
                    AssetTag = "BLDC-GEN-EXH-STACK", 
                    Name = "Generator Exhaust Stack", 
                    Category = "Power",
                    Location = "Building C – Exterior", 
                    IsRetired = false
                },

                new Asset
                {
                    AssetTag = "BLDA-LTNG-LUTRON-F1", 
                    Name = "Lutron Lighting Panel – Floor 1", 
                    Category = "Electrical",
                    Location = "Building A – Electrical Room", 
                    IsRetired = false
                },
                new Asset
                {
                    AssetTag = "BLDA-LTNG-LUTRON-F2",
                    Name = "Lutron Lighting Panel – Floor 2", 
                    Category = "Electrical",
                    Location = "Building A – Electrical Room", 
                    IsRetired = false
                },

                new Asset
                {
                    AssetTag = "BLDA-XFRM-ABB-01", 
                    Name = "ABB Electrical Transformer", 
                    Category = "Electrical",
                    Location = "Building A – Substation", 
                    IsRetired = false
                },
                new Asset
                {
                    AssetTag = "BLDB-XFRM-SIEMENS", 
                    Name = "Siemens Electrical Transformer", 
                    Category = "Electrical",
                    Location = "Building B – Substation", 
                    IsRetired = false
                },

                new Asset
                {
                    AssetTag = "BLDA-VENT-GREENHECK-E", 
                    Name = "Greenheck Roof Vent – East",
                    Category = "HVAC",
                    Location = "Building A – Roof", 
                    IsRetired = false
                },
                new Asset
                {
                    AssetTag = "BLDA-VENT-GREENHECK-W", 
                    Name = "Greenheck Roof Vent – West", 
                    Category = "HVAC",
                    Location = "Building A – Roof", 
                    IsRetired = false
                },

                new Asset
                {
                    AssetTag = "BLDB-SEC-RACK-01", 
                    Name = "Security Equipment Rack", 
                    Category = "Security",
                    Location = "Building B – Security Room", 
                    IsRetired = false
                },

                new Asset
                {
                    AssetTag = "BLDD-RACK-APC-A7", 
                    Name = "APC Data Rack – Row A7", 
                    Category = "IT Infrastructure",
                    Location = "Building D – Data Center", 
                    IsRetired = false
                },
                new Asset
                {
                    AssetTag = "BLDD-RACK-APC-B2", 
                    Name = "APC Data Rack – Row B2", 
                    Category = "IT Infrastructure",
                    Location = "Building D – Data Center", 
                    IsRetired = false
                },
                new Asset
                {
                    AssetTag = "BLDD-RACK-APC-C9", 
                    Name = "APC Data Rack – Row C9", 
                    Category = "IT Infrastructure",
                    Location = "Building D – Data Center", 
                    IsRetired = false
                }

            ];
        }


    }
}
