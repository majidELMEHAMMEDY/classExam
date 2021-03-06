﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ControlLingToSql
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="p1_cnx_sql")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertuser(user instance);
    partial void Updateuser(user instance);
    partial void Deleteuser(user instance);
    partial void Insertdepartement(departement instance);
    partial void Updatedepartement(departement instance);
    partial void Deletedepartement(departement instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::ControlLingToSql.Properties.Settings.Default.p1_cnx_sqlConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<user> users
		{
			get
			{
				return this.GetTable<user>();
			}
		}
		
		public System.Data.Linq.Table<login> logins
		{
			get
			{
				return this.GetTable<login>();
			}
		}
		
		public System.Data.Linq.Table<departement> departements
		{
			get
			{
				return this.GetTable<departement>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[user]")]
	public partial class user : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _empno;
		
		private string _empname;
		
		private string _job;
		
		private System.Nullable<int> _supervisor;
		
		private System.Nullable<int> _deptno;
		
		private System.Nullable<int> _salaire;
		
		private System.Nullable<System.DateTime> _datenaiss;
		
		private System.Nullable<bool> _sexe;
		
		private string _civilite;
		
		private EntityRef<departement> _departement;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnempnoChanging(int value);
    partial void OnempnoChanged();
    partial void OnempnameChanging(string value);
    partial void OnempnameChanged();
    partial void OnjobChanging(string value);
    partial void OnjobChanged();
    partial void OnsupervisorChanging(System.Nullable<int> value);
    partial void OnsupervisorChanged();
    partial void OndeptnoChanging(System.Nullable<int> value);
    partial void OndeptnoChanged();
    partial void OnsalaireChanging(System.Nullable<int> value);
    partial void OnsalaireChanged();
    partial void OndatenaissChanging(System.Nullable<System.DateTime> value);
    partial void OndatenaissChanged();
    partial void OnsexeChanging(System.Nullable<bool> value);
    partial void OnsexeChanged();
    partial void OnciviliteChanging(string value);
    partial void OnciviliteChanged();
    #endregion
		
		public user()
		{
			this._departement = default(EntityRef<departement>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_empno", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int empno
		{
			get
			{
				return this._empno;
			}
			set
			{
				if ((this._empno != value))
				{
					this.OnempnoChanging(value);
					this.SendPropertyChanging();
					this._empno = value;
					this.SendPropertyChanged("empno");
					this.OnempnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_empname", DbType="VarChar(50)")]
		public string empname
		{
			get
			{
				return this._empname;
			}
			set
			{
				if ((this._empname != value))
				{
					this.OnempnameChanging(value);
					this.SendPropertyChanging();
					this._empname = value;
					this.SendPropertyChanged("empname");
					this.OnempnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_job", DbType="VarChar(50)")]
		public string job
		{
			get
			{
				return this._job;
			}
			set
			{
				if ((this._job != value))
				{
					this.OnjobChanging(value);
					this.SendPropertyChanging();
					this._job = value;
					this.SendPropertyChanged("job");
					this.OnjobChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_supervisor", DbType="Int")]
		public System.Nullable<int> supervisor
		{
			get
			{
				return this._supervisor;
			}
			set
			{
				if ((this._supervisor != value))
				{
					this.OnsupervisorChanging(value);
					this.SendPropertyChanging();
					this._supervisor = value;
					this.SendPropertyChanged("supervisor");
					this.OnsupervisorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_deptno", DbType="Int")]
		public System.Nullable<int> deptno
		{
			get
			{
				return this._deptno;
			}
			set
			{
				if ((this._deptno != value))
				{
					if (this._departement.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OndeptnoChanging(value);
					this.SendPropertyChanging();
					this._deptno = value;
					this.SendPropertyChanged("deptno");
					this.OndeptnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_salaire", DbType="Int")]
		public System.Nullable<int> salaire
		{
			get
			{
				return this._salaire;
			}
			set
			{
				if ((this._salaire != value))
				{
					this.OnsalaireChanging(value);
					this.SendPropertyChanging();
					this._salaire = value;
					this.SendPropertyChanged("salaire");
					this.OnsalaireChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_datenaiss", DbType="DateTime")]
		public System.Nullable<System.DateTime> datenaiss
		{
			get
			{
				return this._datenaiss;
			}
			set
			{
				if ((this._datenaiss != value))
				{
					this.OndatenaissChanging(value);
					this.SendPropertyChanging();
					this._datenaiss = value;
					this.SendPropertyChanged("datenaiss");
					this.OndatenaissChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sexe", DbType="Bit")]
		public System.Nullable<bool> sexe
		{
			get
			{
				return this._sexe;
			}
			set
			{
				if ((this._sexe != value))
				{
					this.OnsexeChanging(value);
					this.SendPropertyChanging();
					this._sexe = value;
					this.SendPropertyChanged("sexe");
					this.OnsexeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_civilite", DbType="VarChar(50)")]
		public string civilite
		{
			get
			{
				return this._civilite;
			}
			set
			{
				if ((this._civilite != value))
				{
					this.OnciviliteChanging(value);
					this.SendPropertyChanging();
					this._civilite = value;
					this.SendPropertyChanged("civilite");
					this.OnciviliteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="departement_user", Storage="_departement", ThisKey="deptno", OtherKey="IDDEP", IsForeignKey=true)]
		public departement departement
		{
            
			get
			{
				return this._departement.Entity;
			}
			set
			{
				departement previousValue = this._departement.Entity;
				if (((previousValue != value) 
							|| (this._departement.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._departement.Entity = null;
						previousValue.users.Remove(this);
					}
					this._departement.Entity = value;
					if ((value != null))
					{
						value.users.Add(this);
						this._deptno = value.IDDEP;
					}
					else
					{
						this._deptno = default(Nullable<int>);
					}
					this.SendPropertyChanged("departement");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.login")]
	public partial class login
	{
		
		private string _login1;
		
		private string _password;
		
		public login()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="login", Storage="_login1", DbType="VarChar(50)")]
		public string login1
		{
			get
			{
				return this._login1;
			}
			set
			{
				if ((this._login1 != value))
				{
					this._login1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(50)")]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this._password = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.departement")]
	public partial class departement : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IDDEP;
		
		private string _depname;
		
		private string _sites;
		
		private EntitySet<user> _users;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDDEPChanging(int value);
    partial void OnIDDEPChanged();
    partial void OndepnameChanging(string value);
    partial void OndepnameChanged();
    partial void OnsitesChanging(string value);
    partial void OnsitesChanged();
    #endregion
		
		public departement()
		{
			this._users = new EntitySet<user>(new Action<user>(this.attach_users), new Action<user>(this.detach_users));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDDEP", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IDDEP
		{
			get
			{
				return this._IDDEP;
			}
			set
			{
				if ((this._IDDEP != value))
				{
					this.OnIDDEPChanging(value);
					this.SendPropertyChanging();
					this._IDDEP = value;
					this.SendPropertyChanged("IDDEP");
					this.OnIDDEPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_depname", DbType="VarChar(50)")]
		public string depname
		{
			get
			{
				return this._depname;
			}
			set
			{
				if ((this._depname != value))
				{
					this.OndepnameChanging(value);
					this.SendPropertyChanging();
					this._depname = value;
					this.SendPropertyChanged("depname");
					this.OndepnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sites", DbType="VarChar(50)")]
		public string sites
		{
			get
			{
				return this._sites;
			}
			set
			{
				if ((this._sites != value))
				{
					this.OnsitesChanging(value);
					this.SendPropertyChanging();
					this._sites = value;
					this.SendPropertyChanged("sites");
					this.OnsitesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="departement_user", Storage="_users", ThisKey="IDDEP", OtherKey="deptno")]
		public EntitySet<user> users
		{
			get
			{
				return this._users;
			}
			set
			{
				this._users.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_users(user entity)
		{
			this.SendPropertyChanging();
			entity.departement = this;
		}
		
		private void detach_users(user entity)
		{
			this.SendPropertyChanging();
			entity.departement = null;
		}
	}
}
#pragma warning restore 1591
