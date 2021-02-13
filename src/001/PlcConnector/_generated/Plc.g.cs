using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;
using PlcConnector.Properties;

[assembly: Vortex.Connector.Attributes.AssemblyPlcCounterPart("{\r\n  \"Types\": [\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"\\\" }\",\r\n      \"TypeName\": \"fbDrive\",\r\n      \"Namespace\": \"Plc\",\r\n      \"TypeMetaInfo\": 4\r\n    },\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"\\\" }\",\r\n      \"TypeName\": \"fbDriveTest\",\r\n      \"Namespace\": \"Plc\",\r\n      \"TypeMetaInfo\": 4\r\n    },\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"\\\" }\",\r\n      \"TypeName\": \"MAIN_TESTS\",\r\n      \"Namespace\": \"Plc\",\r\n      \"TypeMetaInfo\": 3\r\n    }\r\n  ],\r\n  \"Name\": \"Plc\",\r\n  \"Namespace\": \"Plc\"\r\n}")]
namespace Plc
{
	public partial class PlcTwinController : Vortex.Connector.ITwinController, IPlcTwinController, IShadowPlcTwinController
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
		MAIN_TESTS _MAIN_TESTS;
		internal MAIN_TESTS MAIN_TESTS
		{
			get
			{
				return _MAIN_TESTS;
			}
		}

		public void LazyOnlineToShadow()
		{
		}

		public void LazyShadowToOnline()
		{
		}

		public PlainPlcTwinController CreatePlainerType()
		{
			var cloned = new PlainPlcTwinController();
			cloned.MAIN_TESTS = MAIN_TESTS.CreatePlainerType();
			return cloned;
		}

		protected PlainPlcTwinController CreatePlainerType(PlainPlcTwinController cloned)
		{
			cloned.MAIN_TESTS = MAIN_TESTS.CreatePlainerType();
			return cloned;
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

		public IPlcTwinController Online
		{
			get
			{
				return (IPlcTwinController)this;
			}
		}

		public IShadowPlcTwinController Shadow
		{
			get
			{
				return (IShadowPlcTwinController)this;
			}
		}

		public Vortex.Connector.IConnector Connector
		{
			get;
			set;
		}

		public PlcTwinController()
		{
			var adapter = new Vortex.Connector.ConnectorAdapter(typeof (DummyConnectorFactory));
			this.Connector = adapter.GetConnector(new object[]{});
			_MAIN_TESTS = new MAIN_TESTS(this.Connector, "", "MAIN_TESTS");
		}

		public PlcTwinController(Vortex.Connector.ConnectorAdapter adapter, object[] parameters)
		{
			this.Connector = adapter.GetConnector(parameters);
			_MAIN_TESTS = new MAIN_TESTS(this.Connector, "", "MAIN_TESTS");
		}

		public PlcTwinController(Vortex.Connector.ConnectorAdapter adapter)
		{
			this.Connector = adapter.GetConnector(adapter.Parameters);
			_MAIN_TESTS = new MAIN_TESTS(this.Connector, "", "MAIN_TESTS");
		}

		public static string LocalizationDirectory
		{
			get;
			set;
		}

		private static Vortex.Localizations.Abstractions.ITranslator _translator
		{
			get;
			set;
		}

		internal static Vortex.Localizations.Abstractions.ITranslator Translator
		{
			get
			{
				if (_translator == null)
				{
					_translator = Vortex.Localizations.Abstractions.ITranslator.Get(typeof (Localizations));
				} return  _translator ; 

			}
		}
	}

	public partial interface IPlcTwinController
	{
		System.String AttributeName
		{
			get;
		}

		Plc.PlainPlcTwinController CreatePlainerType();
	}

	public partial interface IShadowPlcTwinController
	{
		System.String AttributeName
		{
			get;
		}

		Plc.PlainPlcTwinController CreatePlainerType();
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainPlcTwinController : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		PlainMAIN_TESTS _MAIN_TESTS;
		internal PlainMAIN_TESTS MAIN_TESTS
		{
			get
			{
				return _MAIN_TESTS;
			}

			set
			{
				if (_MAIN_TESTS != value)
				{
					_MAIN_TESTS = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(MAIN_TESTS)));
				}
			}
		}

		public void CopyPlainToCyclic(Plc.PlcTwinController target)
		{
			MAIN_TESTS.CopyPlainToCyclic(target.MAIN_TESTS);
		}

		public void CopyPlainToCyclic(Plc.IPlcTwinController target)
		{
			this.CopyPlainToCyclic((Plc.PlcTwinController)target);
		}

		public void CopyPlainToShadow(Plc.PlcTwinController target)
		{
			MAIN_TESTS.CopyPlainToShadow(target.MAIN_TESTS);
		}

		public void CopyPlainToShadow(Plc.IShadowPlcTwinController target)
		{
			this.CopyPlainToShadow((Plc.PlcTwinController)target);
		}

		public void CopyCyclicToPlain(Plc.PlcTwinController source)
		{
			MAIN_TESTS.CopyCyclicToPlain(source.MAIN_TESTS);
		}

		public void CopyCyclicToPlain(Plc.IPlcTwinController source)
		{
			this.CopyCyclicToPlain((Plc.PlcTwinController)source);
		}

		public void CopyShadowToPlain(Plc.PlcTwinController source)
		{
			MAIN_TESTS.CopyShadowToPlain(source.MAIN_TESTS);
		}

		public void CopyShadowToPlain(Plc.IShadowPlcTwinController source)
		{
			this.CopyShadowToPlain((Plc.PlcTwinController)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainPlcTwinController()
		{
			_MAIN_TESTS = new PlainMAIN_TESTS();
		}
	}
}