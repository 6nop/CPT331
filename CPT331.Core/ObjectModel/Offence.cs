﻿#region Using References

using System;

#endregion

namespace CPT331.Core.ObjectModel
{
	public class Offence
	{
		public Offence(int id, string name)
			: this(id, name, null)
		{
		}

		public Offence(int id, string name, int? parentID)
			: this (DateTime.UtcNow, DateTime.UtcNow, id, false, true, name, parentID)
		{
		}

		public Offence(DateTime dateCreatedUtc, DateTime dateUpdatedUtc, int id, bool isDeleted, bool isVisible, string name, int? parentID)
		{
			_dateCreatedUtc = dateCreatedUtc;
			_dateUpdatedUtc = dateUpdatedUtc;
			_id = id;
			_isDeleted = isDeleted;
			_isVisible = isVisible;
			_name = name;
			_parentID = parentID;
		}

		private readonly DateTime _dateCreatedUtc;
		private readonly DateTime _dateUpdatedUtc;
		private readonly int _id;
		private readonly bool _isDeleted;
		private readonly bool _isVisible;
		private readonly string _name;
		private readonly int? _parentID;

		public DateTime DateCreatedUtc
		{
			get
			{
				return _dateCreatedUtc;
			}
		}

		public DateTime DateUpdatedUtc
		{
			get
			{
				return _dateUpdatedUtc;
			}
		}

		public int ID
		{
			get
			{
				return _id;
			}
		}

		public bool IsDeleted
		{
			get
			{
				return _isDeleted;
			}
		}

		public bool IsVisible
		{
			get
			{
				return _isVisible;
			}
		}

		public string Name
		{
			get
			{
				return _name;
			}
		}

		public int? ParentID
		{
			get
			{
				return _parentID;
			}
		}

		public override int GetHashCode()
		{
			int getHashCode =
				_dateCreatedUtc.GetHashCode() ^
				_dateUpdatedUtc.GetHashCode() ^
				_id.GetHashCode() ^
				_isDeleted.GetHashCode() ^
				_isVisible.GetHashCode() ^
				_parentID.GetHashCode();

			if (String.IsNullOrEmpty(_name) == false)
			{
				getHashCode ^= _name.GetHashCode();
			}

			return getHashCode;
		}

		public override bool Equals(object value)
		{
			bool equals = false;
			Offence offence = value as Offence;

			if (offence != null)
			{
				equals =
				(
					(_dateCreatedUtc == offence._dateCreatedUtc) &&
					(_dateUpdatedUtc == offence._dateUpdatedUtc) &&
					(_id == offence._id) &&
					(_isDeleted == offence._isDeleted) &&
					(_isVisible == offence._isDeleted) &&
					(_name == offence._name) &&
					(_parentID == offence._parentID)
				);
			}

			return equals;
		}
	}
}