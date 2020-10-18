
using System;

namespace DDD.Domain.Entities
{
    public sealed class WeatherEntity
    {
        //完全コンストラクタ・パターン
        public WeatherEntity(int areaId,
                            DateTime dataDate,
                            int condition,
                            float temperature)
        {
            AreaId = areaId;
            DataDate = dataDate;
            Condition = condition;
            Temperature = temperature;
        }

        public int AreaId { get;}
        public DateTime DataDate { get; }
        public int Condition { get; }
        public float Temperature { get; }

    }
}
