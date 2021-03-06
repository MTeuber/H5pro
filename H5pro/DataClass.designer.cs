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

namespace H5pro
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="H5projekt")]
	public partial class DataClassDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertTv(Tv instance);
    partial void UpdateTv(Tv instance);
    partial void DeleteTv(Tv instance);
    partial void InsertMovies(Movies instance);
    partial void UpdateMovies(Movies instance);
    partial void DeleteMovies(Movies instance);
    partial void InsertMessage(Message instance);
    partial void UpdateMessage(Message instance);
    partial void DeleteMessage(Message instance);
    partial void InsertMatchCriteria(MatchCriteria instance);
    partial void UpdateMatchCriteria(MatchCriteria instance);
    partial void DeleteMatchCriteria(MatchCriteria instance);
    #endregion
		
		public DataClassDataContext() : 
				base(global::H5pro.Properties.Settings.Default.H5projektConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<Tv> Tvs
		{
			get
			{
				return this.GetTable<Tv>();
			}
		}
		
		public System.Data.Linq.Table<Movies> Movies
		{
			get
			{
				return this.GetTable<Movies>();
			}
		}
		
		public System.Data.Linq.Table<Message> Messages
		{
			get
			{
				return this.GetTable<Message>();
			}
		}
		
		public System.Data.Linq.Table<MatchCriteria> MatchCriterias
		{
			get
			{
				return this.GetTable<MatchCriteria>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Email;
		
		private string _UserName;
		
		private string _Password;
		
		private System.Nullable<int> _Age;
		
		private System.Nullable<int> _Gender;
		
		private System.Nullable<int> _RememberMe;
		
		private System.Nullable<int> _MatchCriteria;
		
		private string _StreamingService;
		
		private EntitySet<Message> _Messages;
		
		private EntitySet<Message> _Messages1;
		
		private EntityRef<MatchCriteria> _MatchCriteria1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnAgeChanging(System.Nullable<int> value);
    partial void OnAgeChanged();
    partial void OnGenderChanging(System.Nullable<int> value);
    partial void OnGenderChanged();
    partial void OnRememberMeChanging(System.Nullable<int> value);
    partial void OnRememberMeChanged();
    partial void OnMatchCriteriaChanging(System.Nullable<int> value);
    partial void OnMatchCriteriaChanged();
    partial void OnStreamingServiceChanging(string value);
    partial void OnStreamingServiceChanged();
    #endregion
		
		public User()
		{
			this._Messages = new EntitySet<Message>(new Action<Message>(this.attach_Messages), new Action<Message>(this.detach_Messages));
			this._Messages1 = new EntitySet<Message>(new Action<Message>(this.attach_Messages1), new Action<Message>(this.detach_Messages1));
			this._MatchCriteria1 = default(EntityRef<MatchCriteria>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(255)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="VarChar(255)")]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(255)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Age", DbType="Int")]
		public System.Nullable<int> Age
		{
			get
			{
				return this._Age;
			}
			set
			{
				if ((this._Age != value))
				{
					this.OnAgeChanging(value);
					this.SendPropertyChanging();
					this._Age = value;
					this.SendPropertyChanged("Age");
					this.OnAgeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="Int")]
		public System.Nullable<int> Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RememberMe", DbType="Int")]
		public System.Nullable<int> RememberMe
		{
			get
			{
				return this._RememberMe;
			}
			set
			{
				if ((this._RememberMe != value))
				{
					this.OnRememberMeChanging(value);
					this.SendPropertyChanging();
					this._RememberMe = value;
					this.SendPropertyChanged("RememberMe");
					this.OnRememberMeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MatchCriteria", DbType="Int")]
		public System.Nullable<int> MatchCriteria
		{
			get
			{
				return this._MatchCriteria;
			}
			set
			{
				if ((this._MatchCriteria != value))
				{
					if (this._MatchCriteria1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMatchCriteriaChanging(value);
					this.SendPropertyChanging();
					this._MatchCriteria = value;
					this.SendPropertyChanged("MatchCriteria");
					this.OnMatchCriteriaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StreamingService", DbType="VarChar(255)")]
		public string StreamingService
		{
			get
			{
				return this._StreamingService;
			}
			set
			{
				if ((this._StreamingService != value))
				{
					this.OnStreamingServiceChanging(value);
					this.SendPropertyChanging();
					this._StreamingService = value;
					this.SendPropertyChanged("StreamingService");
					this.OnStreamingServiceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Message", Storage="_Messages", ThisKey="Id", OtherKey="MessageTo")]
		public EntitySet<Message> Messages
		{
			get
			{
				return this._Messages;
			}
			set
			{
				this._Messages.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Message1", Storage="_Messages1", ThisKey="Id", OtherKey="Messagefrom")]
		public EntitySet<Message> Messages1
		{
			get
			{
				return this._Messages1;
			}
			set
			{
				this._Messages1.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="MatchCriteria_User", Storage="_MatchCriteria1", ThisKey="MatchCriteria", OtherKey="Id", IsForeignKey=true)]
		public MatchCriteria MatchCriteria1
		{
			get
			{
				return this._MatchCriteria1.Entity;
			}
			set
			{
				MatchCriteria previousValue = this._MatchCriteria1.Entity;
				if (((previousValue != value) 
							|| (this._MatchCriteria1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._MatchCriteria1.Entity = null;
						previousValue.Users.Remove(this);
					}
					this._MatchCriteria1.Entity = value;
					if ((value != null))
					{
						value.Users.Add(this);
						this._MatchCriteria = value.Id;
					}
					else
					{
						this._MatchCriteria = default(Nullable<int>);
					}
					this.SendPropertyChanged("MatchCriteria1");
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
		
		private void attach_Messages(Message entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Messages(Message entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
		
		private void attach_Messages1(Message entity)
		{
			this.SendPropertyChanging();
			entity.User1 = this;
		}
		
		private void detach_Messages1(Message entity)
		{
			this.SendPropertyChanging();
			entity.User1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tv")]
	public partial class Tv : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Title;
		
		private string _Genre;
		
		private System.Nullable<int> _Seasons;
		
		private string _Description;
		
		private EntitySet<MatchCriteria> _MatchCriterias;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnGenreChanging(string value);
    partial void OnGenreChanged();
    partial void OnSeasonsChanging(System.Nullable<int> value);
    partial void OnSeasonsChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    #endregion
		
		public Tv()
		{
			this._MatchCriterias = new EntitySet<MatchCriteria>(new Action<MatchCriteria>(this.attach_MatchCriterias), new Action<MatchCriteria>(this.detach_MatchCriterias));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="VarChar(255)")]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Genre", DbType="VarChar(255)")]
		public string Genre
		{
			get
			{
				return this._Genre;
			}
			set
			{
				if ((this._Genre != value))
				{
					this.OnGenreChanging(value);
					this.SendPropertyChanging();
					this._Genre = value;
					this.SendPropertyChanged("Genre");
					this.OnGenreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Seasons", DbType="Int")]
		public System.Nullable<int> Seasons
		{
			get
			{
				return this._Seasons;
			}
			set
			{
				if ((this._Seasons != value))
				{
					this.OnSeasonsChanging(value);
					this.SendPropertyChanging();
					this._Seasons = value;
					this.SendPropertyChanged("Seasons");
					this.OnSeasonsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="VarChar(255)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Tv_MatchCriteria", Storage="_MatchCriterias", ThisKey="Id", OtherKey="Gender")]
		public EntitySet<MatchCriteria> MatchCriterias
		{
			get
			{
				return this._MatchCriterias;
			}
			set
			{
				this._MatchCriterias.Assign(value);
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
		
		private void attach_MatchCriterias(MatchCriteria entity)
		{
			this.SendPropertyChanging();
			entity.Tv = this;
		}
		
		private void detach_MatchCriterias(MatchCriteria entity)
		{
			this.SendPropertyChanging();
			entity.Tv = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Movies")]
	public partial class Movies : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Title;
		
		private string _Gerne;
		
		private System.Nullable<int> _Length;
		
		private string _Descrition;
		
		private EntitySet<MatchCriteria> _MatchCriterias;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnGerneChanging(string value);
    partial void OnGerneChanged();
    partial void OnLengthChanging(System.Nullable<int> value);
    partial void OnLengthChanged();
    partial void OnDescritionChanging(string value);
    partial void OnDescritionChanged();
    #endregion
		
		public Movies()
		{
			this._MatchCriterias = new EntitySet<MatchCriteria>(new Action<MatchCriteria>(this.attach_MatchCriterias), new Action<MatchCriteria>(this.detach_MatchCriterias));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="VarChar(255)")]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gerne", DbType="VarChar(255)")]
		public string Gerne
		{
			get
			{
				return this._Gerne;
			}
			set
			{
				if ((this._Gerne != value))
				{
					this.OnGerneChanging(value);
					this.SendPropertyChanging();
					this._Gerne = value;
					this.SendPropertyChanged("Gerne");
					this.OnGerneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Length", DbType="Int")]
		public System.Nullable<int> Length
		{
			get
			{
				return this._Length;
			}
			set
			{
				if ((this._Length != value))
				{
					this.OnLengthChanging(value);
					this.SendPropertyChanging();
					this._Length = value;
					this.SendPropertyChanged("Length");
					this.OnLengthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descrition", DbType="VarChar(255)")]
		public string Descrition
		{
			get
			{
				return this._Descrition;
			}
			set
			{
				if ((this._Descrition != value))
				{
					this.OnDescritionChanging(value);
					this.SendPropertyChanging();
					this._Descrition = value;
					this.SendPropertyChanged("Descrition");
					this.OnDescritionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Movy_MatchCriteria", Storage="_MatchCriterias", ThisKey="Id", OtherKey="IntoTV")]
		public EntitySet<MatchCriteria> MatchCriterias
		{
			get
			{
				return this._MatchCriterias;
			}
			set
			{
				this._MatchCriterias.Assign(value);
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
		
		private void attach_MatchCriterias(MatchCriteria entity)
		{
			this.SendPropertyChanging();
			entity.Movies = this;
		}
		
		private void detach_MatchCriterias(MatchCriteria entity)
		{
			this.SendPropertyChanging();
			entity.Movies = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Messages")]
	public partial class Message : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<int> _MessageTo;
		
		private System.Nullable<int> _Messagefrom;
		
		private string _Text;
		
		private System.Nullable<int> _sent;
		
		private EntityRef<User> _User;
		
		private EntityRef<User> _User1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnMessageToChanging(System.Nullable<int> value);
    partial void OnMessageToChanged();
    partial void OnMessagefromChanging(System.Nullable<int> value);
    partial void OnMessagefromChanged();
    partial void OnTextChanging(string value);
    partial void OnTextChanged();
    partial void OnsentChanging(System.Nullable<int> value);
    partial void OnsentChanged();
    #endregion
		
		public Message()
		{
			this._User = default(EntityRef<User>);
			this._User1 = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MessageTo", DbType="Int")]
		public System.Nullable<int> MessageTo
		{
			get
			{
				return this._MessageTo;
			}
			set
			{
				if ((this._MessageTo != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMessageToChanging(value);
					this.SendPropertyChanging();
					this._MessageTo = value;
					this.SendPropertyChanged("MessageTo");
					this.OnMessageToChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Messagefrom", DbType="Int")]
		public System.Nullable<int> Messagefrom
		{
			get
			{
				return this._Messagefrom;
			}
			set
			{
				if ((this._Messagefrom != value))
				{
					if (this._User1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMessagefromChanging(value);
					this.SendPropertyChanging();
					this._Messagefrom = value;
					this.SendPropertyChanged("Messagefrom");
					this.OnMessagefromChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Text", DbType="VarChar(255)")]
		public string Text
		{
			get
			{
				return this._Text;
			}
			set
			{
				if ((this._Text != value))
				{
					this.OnTextChanging(value);
					this.SendPropertyChanging();
					this._Text = value;
					this.SendPropertyChanged("Text");
					this.OnTextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sent", DbType="Int")]
		public System.Nullable<int> sent
		{
			get
			{
				return this._sent;
			}
			set
			{
				if ((this._sent != value))
				{
					this.OnsentChanging(value);
					this.SendPropertyChanging();
					this._sent = value;
					this.SendPropertyChanged("sent");
					this.OnsentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Message", Storage="_User", ThisKey="MessageTo", OtherKey="Id", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Messages.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Messages.Add(this);
						this._MessageTo = value.Id;
					}
					else
					{
						this._MessageTo = default(Nullable<int>);
					}
					this.SendPropertyChanged("User");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Message1", Storage="_User1", ThisKey="Messagefrom", OtherKey="Id", IsForeignKey=true)]
		public User User1
		{
			get
			{
				return this._User1.Entity;
			}
			set
			{
				User previousValue = this._User1.Entity;
				if (((previousValue != value) 
							|| (this._User1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User1.Entity = null;
						previousValue.Messages1.Remove(this);
					}
					this._User1.Entity = value;
					if ((value != null))
					{
						value.Messages1.Add(this);
						this._Messagefrom = value.Id;
					}
					else
					{
						this._Messagefrom = default(Nullable<int>);
					}
					this.SendPropertyChanged("User1");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MatchCriteria")]
	public partial class MatchCriteria : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<int> _Gender;
		
		private System.Nullable<int> _IntoTV;
		
		private System.Nullable<int> _IntoMovies;
		
		private System.Nullable<int> _Commitment;
		
		private EntitySet<User> _Users;
		
		private EntityRef<Tv> _Tv;
		
		private EntityRef<Movies> _Movies;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnGenderChanging(System.Nullable<int> value);
    partial void OnGenderChanged();
    partial void OnIntoTVChanging(System.Nullable<int> value);
    partial void OnIntoTVChanged();
    partial void OnIntoMoviesChanging(System.Nullable<int> value);
    partial void OnIntoMoviesChanged();
    partial void OnCommitmentChanging(System.Nullable<int> value);
    partial void OnCommitmentChanged();
    #endregion
		
		public MatchCriteria()
		{
			this._Users = new EntitySet<User>(new Action<User>(this.attach_Users), new Action<User>(this.detach_Users));
			this._Tv = default(EntityRef<Tv>);
			this._Movies = default(EntityRef<Movies>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="Int")]
		public System.Nullable<int> Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					if (this._Tv.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IntoTV", DbType="Int")]
		public System.Nullable<int> IntoTV
		{
			get
			{
				return this._IntoTV;
			}
			set
			{
				if ((this._IntoTV != value))
				{
					if (this._Movies.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIntoTVChanging(value);
					this.SendPropertyChanging();
					this._IntoTV = value;
					this.SendPropertyChanged("IntoTV");
					this.OnIntoTVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IntoMovies", DbType="Int")]
		public System.Nullable<int> IntoMovies
		{
			get
			{
				return this._IntoMovies;
			}
			set
			{
				if ((this._IntoMovies != value))
				{
					this.OnIntoMoviesChanging(value);
					this.SendPropertyChanging();
					this._IntoMovies = value;
					this.SendPropertyChanged("IntoMovies");
					this.OnIntoMoviesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Commitment", DbType="Int")]
		public System.Nullable<int> Commitment
		{
			get
			{
				return this._Commitment;
			}
			set
			{
				if ((this._Commitment != value))
				{
					this.OnCommitmentChanging(value);
					this.SendPropertyChanging();
					this._Commitment = value;
					this.SendPropertyChanged("Commitment");
					this.OnCommitmentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="MatchCriteria_User", Storage="_Users", ThisKey="Id", OtherKey="MatchCriteria")]
		public EntitySet<User> Users
		{
			get
			{
				return this._Users;
			}
			set
			{
				this._Users.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Tv_MatchCriteria", Storage="_Tv", ThisKey="Gender", OtherKey="Id", IsForeignKey=true)]
		public Tv Tv
		{
			get
			{
				return this._Tv.Entity;
			}
			set
			{
				Tv previousValue = this._Tv.Entity;
				if (((previousValue != value) 
							|| (this._Tv.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Tv.Entity = null;
						previousValue.MatchCriterias.Remove(this);
					}
					this._Tv.Entity = value;
					if ((value != null))
					{
						value.MatchCriterias.Add(this);
						this._Gender = value.Id;
					}
					else
					{
						this._Gender = default(Nullable<int>);
					}
					this.SendPropertyChanged("Tv");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Movy_MatchCriteria", Storage="_Movies", ThisKey="IntoTV", OtherKey="Id", IsForeignKey=true)]
		public Movies Movies
		{
			get
			{
				return this._Movies.Entity;
			}
			set
			{
				Movies previousValue = this._Movies.Entity;
				if (((previousValue != value) 
							|| (this._Movies.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Movies.Entity = null;
						previousValue.MatchCriterias.Remove(this);
					}
					this._Movies.Entity = value;
					if ((value != null))
					{
						value.MatchCriterias.Add(this);
						this._IntoTV = value.Id;
					}
					else
					{
						this._IntoTV = default(Nullable<int>);
					}
					this.SendPropertyChanged("Movies");
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
		
		private void attach_Users(User entity)
		{
			this.SendPropertyChanging();
			entity.MatchCriteria1 = this;
		}
		
		private void detach_Users(User entity)
		{
			this.SendPropertyChanging();
			entity.MatchCriteria1 = null;
		}
	}
}
#pragma warning restore 1591
