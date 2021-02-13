using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc
{
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "fbDrive", "Plc", TypeComplexityEnum.Complex)]
	public partial class fbDrive : Vortex.Connector.IVortexObject, IfbDrive, IShadowfbDrive, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		public string Symbol
		{
			get;
			protected set;
		}

		public string HumanReadable
		{
			get
			{
				return PlcTwinController.Translator.Translate(_humanReadable).Interpolate(this);
			}

			protected set
			{
				_humanReadable = value;
			}
		}

		protected string _humanReadable;
		Vortex.Connector.ValueTypes.OnlinerLReal __position;
		public Vortex.Connector.ValueTypes.OnlinerLReal _position
		{
			get
			{
				return __position;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineLReal IfbDrive._position
		{
			get
			{
				return _position;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowLReal IShadowfbDrive._position
		{
			get
			{
				return _position;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerLReal __speed;
		public Vortex.Connector.ValueTypes.OnlinerLReal _speed
		{
			get
			{
				return __speed;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineLReal IfbDrive._speed
		{
			get
			{
				return _speed;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowLReal IShadowfbDrive._speed
		{
			get
			{
				return _speed;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerLReal __acc_dcc;
		public Vortex.Connector.ValueTypes.OnlinerLReal _acc_dcc
		{
			get
			{
				return __acc_dcc;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineLReal IfbDrive._acc_dcc
		{
			get
			{
				return _acc_dcc;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowLReal IShadowfbDrive._acc_dcc
		{
			get
			{
				return _acc_dcc;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerLReal __targetPosition;
		public Vortex.Connector.ValueTypes.OnlinerLReal _targetPosition
		{
			get
			{
				return __targetPosition;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineLReal IfbDrive._targetPosition
		{
			get
			{
				return _targetPosition;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowLReal IShadowfbDrive._targetPosition
		{
			get
			{
				return _targetPosition;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerLReal __targetSpeed;
		public Vortex.Connector.ValueTypes.OnlinerLReal _targetSpeed
		{
			get
			{
				return __targetSpeed;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineLReal IfbDrive._targetSpeed
		{
			get
			{
				return _targetSpeed;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowLReal IShadowfbDrive._targetSpeed
		{
			get
			{
				return _targetSpeed;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerLReal __targetAccDcc;
		public Vortex.Connector.ValueTypes.OnlinerLReal _targetAccDcc
		{
			get
			{
				return __targetAccDcc;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineLReal IfbDrive._targetAccDcc
		{
			get
			{
				return _targetAccDcc;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowLReal IShadowfbDrive._targetAccDcc
		{
			get
			{
				return _targetAccDcc;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerLReal __changextime;
		public Vortex.Connector.ValueTypes.OnlinerLReal _changextime
		{
			get
			{
				return __changextime;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineLReal IfbDrive._changextime
		{
			get
			{
				return _changextime;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowLReal IShadowfbDrive._changextime
		{
			get
			{
				return _changextime;
			}
		}

		public void LazyOnlineToShadow()
		{
			_position.Shadow = _position.LastValue;
			_speed.Shadow = _speed.LastValue;
			_acc_dcc.Shadow = _acc_dcc.LastValue;
			_targetPosition.Shadow = _targetPosition.LastValue;
			_targetSpeed.Shadow = _targetSpeed.LastValue;
			_targetAccDcc.Shadow = _targetAccDcc.LastValue;
			_changextime.Shadow = _changextime.LastValue;
		}

		public void LazyShadowToOnline()
		{
			_position.Cyclic = _position.Shadow;
			_speed.Cyclic = _speed.Shadow;
			_acc_dcc.Cyclic = _acc_dcc.Shadow;
			_targetPosition.Cyclic = _targetPosition.Shadow;
			_targetSpeed.Cyclic = _targetSpeed.Shadow;
			_targetAccDcc.Cyclic = _targetAccDcc.Shadow;
			_changextime.Cyclic = _changextime.Shadow;
		}

		public PlainfbDrive CreatePlainerType()
		{
			var cloned = new PlainfbDrive();
			return cloned;
		}

		protected PlainfbDrive CreatePlainerType(PlainfbDrive cloned)
		{
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		protected Vortex.Connector.IVortexObject @Parent
		{
			get;
			set;
		}

		public Vortex.Connector.IVortexObject GetParent()
		{
			return this.@Parent;
		}

		private System.Collections.Generic.List<Vortex.Connector.IVortexObject> @Children
		{
			get;
			set;
		}

		public System.Collections.Generic.IEnumerable<Vortex.Connector.IVortexObject> @GetChildren()
		{
			return this.@Children;
		}

		public void AddChild(Vortex.Connector.IVortexObject vortexObject)
		{
			this.@Children.Add(vortexObject);
		}

		private System.Collections.Generic.List<Vortex.Connector.IValueTag> @ValueTags
		{
			get;
			set;
		}

		public System.Collections.Generic.IEnumerable<Vortex.Connector.IValueTag> GetValueTags()
		{
			return this.@ValueTags;
		}

		public void AddValueTag(Vortex.Connector.IValueTag valueTag)
		{
			this.@ValueTags.Add(valueTag);
		}

		protected Vortex.Connector.IConnector @Connector
		{
			get;
			set;
		}

		public Vortex.Connector.IConnector GetConnector()
		{
			return this.@Connector;
		}

		public void FlushPlainToOnline(Plc.PlainfbDrive source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc.PlainfbDrive source)
		{
			source.CopyPlainToShadow(this);
		}

		public void FlushShadowToOnline()
		{
			this.LazyShadowToOnline();
			this.Write();
		}

		public void FlushOnlineToShadow()
		{
			this.Read();
			this.LazyOnlineToShadow();
		}

		public void FlushOnlineToPlain(Plc.PlainfbDrive source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		protected System.String @SymbolTail
		{
			get;
			set;
		}

		public System.String GetSymbolTail()
		{
			return this.SymbolTail;
		}

		public System.String AttributeName
		{
			get
			{
				return PlcTwinController.Translator.Translate(_AttributeName).Interpolate(this);
			}

			set
			{
				_AttributeName = value;
			}
		}

		private System.String _AttributeName
		{
			get;
			set;
		}

		public fbDrive(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			__position = @Connector.Online.Adapter.CreateLREAL(this, "", "_position");
			__speed = @Connector.Online.Adapter.CreateLREAL(this, "", "_speed");
			__acc_dcc = @Connector.Online.Adapter.CreateLREAL(this, "", "_acc_dcc");
			__targetPosition = @Connector.Online.Adapter.CreateLREAL(this, "", "_targetPosition");
			__targetSpeed = @Connector.Online.Adapter.CreateLREAL(this, "", "_targetSpeed");
			__targetAccDcc = @Connector.Online.Adapter.CreateLREAL(this, "", "_targetAccDcc");
			__changextime = @Connector.Online.Adapter.CreateLREAL(this, "", "_changextime");
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
			parent.AddChild(this);
		}

		public fbDrive()
		{
			PexPreConstructorParameterless();
			__position = Vortex.Connector.IConnectorFactory.CreateLREAL();
			__speed = Vortex.Connector.IConnectorFactory.CreateLREAL();
			__acc_dcc = Vortex.Connector.IConnectorFactory.CreateLREAL();
			__targetPosition = Vortex.Connector.IConnectorFactory.CreateLREAL();
			__targetSpeed = Vortex.Connector.IConnectorFactory.CreateLREAL();
			__targetAccDcc = Vortex.Connector.IConnectorFactory.CreateLREAL();
			__changextime = Vortex.Connector.IConnectorFactory.CreateLREAL();
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcfbDrive
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcfbDrive()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IfbDrive : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineLReal _position
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineLReal _speed
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineLReal _acc_dcc
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineLReal _targetPosition
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineLReal _targetSpeed
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineLReal _targetAccDcc
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineLReal _changextime
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Plc.PlainfbDrive CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc.PlainfbDrive source);
		void FlushOnlineToPlain(Plc.PlainfbDrive source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowfbDrive : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowLReal _position
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowLReal _speed
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowLReal _acc_dcc
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowLReal _targetPosition
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowLReal _targetSpeed
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowLReal _targetAccDcc
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowLReal _changextime
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Plc.PlainfbDrive CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(Plc.PlainfbDrive source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainfbDrive : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		System.Double __position;
		public System.Double _position
		{
			get
			{
				return __position;
			}

			set
			{
				if (__position != value)
				{
					__position = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_position)));
				}
			}
		}

		System.Double __speed;
		public System.Double _speed
		{
			get
			{
				return __speed;
			}

			set
			{
				if (__speed != value)
				{
					__speed = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_speed)));
				}
			}
		}

		System.Double __acc_dcc;
		public System.Double _acc_dcc
		{
			get
			{
				return __acc_dcc;
			}

			set
			{
				if (__acc_dcc != value)
				{
					__acc_dcc = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_acc_dcc)));
				}
			}
		}

		System.Double __targetPosition;
		public System.Double _targetPosition
		{
			get
			{
				return __targetPosition;
			}

			set
			{
				if (__targetPosition != value)
				{
					__targetPosition = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_targetPosition)));
				}
			}
		}

		System.Double __targetSpeed;
		public System.Double _targetSpeed
		{
			get
			{
				return __targetSpeed;
			}

			set
			{
				if (__targetSpeed != value)
				{
					__targetSpeed = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_targetSpeed)));
				}
			}
		}

		System.Double __targetAccDcc;
		public System.Double _targetAccDcc
		{
			get
			{
				return __targetAccDcc;
			}

			set
			{
				if (__targetAccDcc != value)
				{
					__targetAccDcc = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_targetAccDcc)));
				}
			}
		}

		System.Double __changextime;
		public System.Double _changextime
		{
			get
			{
				return __changextime;
			}

			set
			{
				if (__changextime != value)
				{
					__changextime = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_changextime)));
				}
			}
		}

		public void CopyPlainToCyclic(Plc.fbDrive target)
		{
			target._position.Cyclic = _position;
			target._speed.Cyclic = _speed;
			target._acc_dcc.Cyclic = _acc_dcc;
			target._targetPosition.Cyclic = _targetPosition;
			target._targetSpeed.Cyclic = _targetSpeed;
			target._targetAccDcc.Cyclic = _targetAccDcc;
			target._changextime.Cyclic = _changextime;
		}

		public void CopyPlainToCyclic(Plc.IfbDrive target)
		{
			this.CopyPlainToCyclic((Plc.fbDrive)target);
		}

		public void CopyPlainToShadow(Plc.fbDrive target)
		{
			target._position.Shadow = _position;
			target._speed.Shadow = _speed;
			target._acc_dcc.Shadow = _acc_dcc;
			target._targetPosition.Shadow = _targetPosition;
			target._targetSpeed.Shadow = _targetSpeed;
			target._targetAccDcc.Shadow = _targetAccDcc;
			target._changextime.Shadow = _changextime;
		}

		public void CopyPlainToShadow(Plc.IShadowfbDrive target)
		{
			this.CopyPlainToShadow((Plc.fbDrive)target);
		}

		public void CopyCyclicToPlain(Plc.fbDrive source)
		{
			_position = source._position.LastValue;
			_speed = source._speed.LastValue;
			_acc_dcc = source._acc_dcc.LastValue;
			_targetPosition = source._targetPosition.LastValue;
			_targetSpeed = source._targetSpeed.LastValue;
			_targetAccDcc = source._targetAccDcc.LastValue;
			_changextime = source._changextime.LastValue;
		}

		public void CopyCyclicToPlain(Plc.IfbDrive source)
		{
			this.CopyCyclicToPlain((Plc.fbDrive)source);
		}

		public void CopyShadowToPlain(Plc.fbDrive source)
		{
			_position = source._position.Shadow;
			_speed = source._speed.Shadow;
			_acc_dcc = source._acc_dcc.Shadow;
			_targetPosition = source._targetPosition.Shadow;
			_targetSpeed = source._targetSpeed.Shadow;
			_targetAccDcc = source._targetAccDcc.Shadow;
			_changextime = source._changextime.Shadow;
		}

		public void CopyShadowToPlain(Plc.IShadowfbDrive source)
		{
			this.CopyShadowToPlain((Plc.fbDrive)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainfbDrive()
		{
		}
	}
}