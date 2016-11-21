﻿#region Using References

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;

#endregion

namespace CPT331.WebAPI.Models
{
    /// <summary>
    /// A wrapper for the EventGuardian crime statistics.
    /// </summary>
	[DataContract(Name = "CrimeByCoordinate")]
    public class CrimeByCoordinateModel
    {
        /// <summary>
        /// Creates an instance of CrimeByCoordinateModel using the values provided.
        /// </summary>
        /// <param name="beginYear"></param>
        /// <param name="endYear"></param>
        /// <param name="name"></param>
        /// <param name="offenceModels"></param>
        /// <param name="total"></param>
		public CrimeByCoordinateModel(int beginYear, int endYear, string name, IEnumerable<OffenceModel> offenceModels, int crimeTotal)
        {
            _beginYear = beginYear;
            _endYear = endYear;
            _name = name;
            _offenceModels = offenceModels;
            _crimeTotal = crimeTotal;
        }

        private int _beginYear;
        private int _endYear;
        private string _name;
        private int _crimeTotal;
        private IEnumerable<OffenceModel> _offenceModels;

        /// <summary>
        /// The first year represented in the crime statistics.
        /// </summary>
		[DataMember]
        public int BeginYear
        {
            get
            {
                return _beginYear;
            }
            set
            {
                _beginYear = value;
            }
        }

        /// <summary>
        /// The final year represented in the crime statistics.
        /// </summary>
        [DataMember]
        public int EndYear
        {
            get
            {
                return _endYear;
            }
            set
            {
                _endYear = value;
            }
        }

        /// <summary>
        /// The name of the Local Government Area.
        /// </summary>
        [DataMember]
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        /// <summary>
        /// A list of offenses committed inside the Local Government Area.
        /// </summary>
		[DataMember(Name = "Offences")]
        public IEnumerable<OffenceModel> OffenceModels
        {
            get
            {
                return _offenceModels;
            }
            set
            {
                _offenceModels = value;
            }
        }

        /// <summary>
        /// The total number of crimes commited in the region.
        /// </summary>
		[DataMember]
        public int CrimeTotal
        {
            get
            {
                return _crimeTotal;
            }
            set
            {
                _crimeTotal = value;
            }
        }
    }
}
