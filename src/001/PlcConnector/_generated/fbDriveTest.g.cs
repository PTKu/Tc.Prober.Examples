using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc
{
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "fbDriveTest", "Plc", TypeComplexityEnum.Complex)]
	internal partial class fbDriveTest : Vortex.Connector.IVortexObject, IfbDriveTest, IShadowfbDriveTest, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		fbDrive __drive;
		public fbDrive _drive
		{
			get
			{
				return __drive;
			}
		}

		IfbDrive IfbDriveTest._drive
		{
			get
			{
				return _drive;
			}
		}

		IShadowfbDrive IShadowfbDriveTest._drive
		{
			get
			{
				return _drive;
			}
		}

		public void LazyOnlineToShadow()
		{
			_drive.LazyOnlineToShadow();
		}

		public void LazyShadowToOnline()
		{
			_drive.LazyShadowToOnline();
		}

		public PlainfbDriveTest CreatePlainerType()
		{
			var cloned = new PlainfbDriveTest();
			cloned._drive = _drive.CreatePlainerType();
			return cloned;
		}

		protected PlainfbDriveTest CreatePlainerType(PlainfbDriveTest cloned)
		{
			cloned._drive = _drive.CreatePlainerType();
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

		public void FlushPlainToOnline(Plc.PlainfbDriveTest source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc.PlainfbDriveTest source)
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

		public void FlushOnlineToPlain(Plc.PlainfbDriveTest source)
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

		internal fbDriveTest(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			__drive = new fbDrive(this, "", "_drive");
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
			parent.AddChild(this);
		}

		internal fbDriveTest()
		{
			PexPreConstructorParameterless();
			__drive = new fbDrive();
			AttributeName = "";
			PexConstructorParameterless();
		}

		public System.Boolean MoveAbsoluteTest(System.Double Position, System.Double Speed, System.Double AccDcc)
		{
			return (System.Boolean)Connector.InvokeRpc(this.Symbol, "MoveAbsoluteTest", new object[]{Position, Speed, AccDcc});
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcfbDriveTest
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcfbDriveTest()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	internal partial interface IfbDriveTest : Vortex.Connector.IVortexOnlineObject
	{
		IfbDrive _drive
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Plc.PlainfbDriveTest CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc.PlainfbDriveTest source);
		void FlushOnlineToPlain(Plc.PlainfbDriveTest source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	internal partial interface IShadowfbDriveTest : Vortex.Connector.IVortexShadowObject
	{
		IShadowfbDrive _drive
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Plc.PlainfbDriveTest CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(Plc.PlainfbDriveTest source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	internal partial class PlainfbDriveTest : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		PlainfbDrive __drive;
		public PlainfbDrive _drive
		{
			get
			{
				return __drive;
			}

			set
			{
				if (__drive != value)
				{
					__drive = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_drive)));
				}
			}
		}

		public void CopyPlainToCyclic(Plc.fbDriveTest target)
		{
			_drive.CopyPlainToCyclic(target._drive);
		}

		public void CopyPlainToCyclic(Plc.IfbDriveTest target)
		{
			this.CopyPlainToCyclic((Plc.fbDriveTest)target);
		}

		public void CopyPlainToShadow(Plc.fbDriveTest target)
		{
			_drive.CopyPlainToShadow(target._drive);
		}

		public void CopyPlainToShadow(Plc.IShadowfbDriveTest target)
		{
			this.CopyPlainToShadow((Plc.fbDriveTest)target);
		}

		public void CopyCyclicToPlain(Plc.fbDriveTest source)
		{
			_drive.CopyCyclicToPlain(source._drive);
		}

		public void CopyCyclicToPlain(Plc.IfbDriveTest source)
		{
			this.CopyCyclicToPlain((Plc.fbDriveTest)source);
		}

		public void CopyShadowToPlain(Plc.fbDriveTest source)
		{
			_drive.CopyShadowToPlain(source._drive);
		}

		public void CopyShadowToPlain(Plc.IShadowfbDriveTest source)
		{
			this.CopyShadowToPlain((Plc.fbDriveTest)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainfbDriveTest()
		{
			__drive = new PlainfbDrive();
		}
	}
}