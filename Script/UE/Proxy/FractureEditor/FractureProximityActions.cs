using Script.CoreUObject;
using Script.Library;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.FractureProximityActions")]
	public partial class UFractureProximityActions : UFractureToolSettings, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FractureEditor.FractureProximityActions");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetFromDefaults()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __SetFromDefaults);
			}
		}

		public virtual void SaveAsDefaults()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __SaveAsDefaults);
			}
		}

		private static uint __SetFromDefaults = 0;

		private static uint __SaveAsDefaults = 0;
	}
}