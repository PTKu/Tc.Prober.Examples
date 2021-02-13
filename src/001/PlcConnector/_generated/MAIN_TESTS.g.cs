using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc
{
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "MAIN_TESTS", "Plc", TypeComplexityEnum.Complex)]
	internal partial class MAIN_TESTS : Vortex.Connector.IVortexObject, IMAIN_TESTS, IShadowMAIN_TESTS, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		fbDriveTest __driveTest;
		internal fbDriveTest _driveTest
		{
			get
			{
				return __driveTest;
			}
		}

		public void LazyOnlineToShadow()
		{
		}

		public void LazyShadowToOnline()
		{
		}

		public PlainMAIN_TESTS CreatePlainerType()
		{
			var cloned = new PlainMAIN_TESTS();
			cloned._driveTest = _driveTest.CreatePlainerType();
			return cloned;
		}

		protected PlainMAIN_TESTS CreatePlainerType(PlainMAIN_TESTS cloned)
		{
			cloned._driveTest = _driveTest.CreatePlainerType();
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

		public void FlushPlainToOnline(Plc.PlainMAIN_TESTS source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc.PlainMAIN_TESTS source)
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

		public void FlushOnlineToPlain(Plc.PlainMAIN_TESTS source)
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

		internal MAIN_TESTS(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			__driveTest = new fbDriveTest(this, "", "_driveTest");
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
			parent.AddChild(this);
		}

		internal MAIN_TESTS()
		{
			PexPreConstructorParameterless();
			__driveTest = new fbDriveTest();
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcMAIN_TESTS
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcMAIN_TESTS()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	internal partial interface IMAIN_TESTS : Vortex.Connector.IVortexOnlineObject
	{
		System.String AttributeName
		{
			get;
		}

		Plc.PlainMAIN_TESTS CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc.PlainMAIN_TESTS source);
		void FlushOnlineToPlain(Plc.PlainMAIN_TESTS source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	internal partial interface IShadowMAIN_TESTS : Vortex.Connector.IVortexShadowObject
	{
		System.String AttributeName
		{
			get;
		}

		Plc.PlainMAIN_TESTS CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(Plc.PlainMAIN_TESTS source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	internal partial class PlainMAIN_TESTS : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		PlainfbDriveTest __driveTest;
		internal PlainfbDriveTest _driveTest
		{
			get
			{
				return __driveTest;
			}

			set
			{
				if (__driveTest != value)
				{
					__driveTest = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_driveTest)));
				}
			}
		}

		public void CopyPlainToCyclic(Plc.MAIN_TESTS target)
		{
			_driveTest.CopyPlainToCyclic(target._driveTest);
		}

		public void CopyPlainToCyclic(Plc.IMAIN_TESTS target)
		{
			this.CopyPlainToCyclic((Plc.MAIN_TESTS)target);
		}

		public void CopyPlainToShadow(Plc.MAIN_TESTS target)
		{
			_driveTest.CopyPlainToShadow(target._driveTest);
		}

		public void CopyPlainToShadow(Plc.IShadowMAIN_TESTS target)
		{
			this.CopyPlainToShadow((Plc.MAIN_TESTS)target);
		}

		public void CopyCyclicToPlain(Plc.MAIN_TESTS source)
		{
			_driveTest.CopyCyclicToPlain(source._driveTest);
		}

		public void CopyCyclicToPlain(Plc.IMAIN_TESTS source)
		{
			this.CopyCyclicToPlain((Plc.MAIN_TESTS)source);
		}

		public void CopyShadowToPlain(Plc.MAIN_TESTS source)
		{
			_driveTest.CopyShadowToPlain(source._driveTest);
		}

		public void CopyShadowToPlain(Plc.IShadowMAIN_TESTS source)
		{
			this.CopyShadowToPlain((Plc.MAIN_TESTS)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainMAIN_TESTS()
		{
			__driveTest = new PlainfbDriveTest();
		}
	}
}