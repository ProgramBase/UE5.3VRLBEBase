using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.LevelEditorViewportInstanceSettingsKeyValuePair")]
	public partial class FLevelEditorViewportInstanceSettingsKeyValuePair : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UnrealEd.LevelEditorViewportInstanceSettingsKeyValuePair");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLevelEditorViewportInstanceSettingsKeyValuePair() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLevelEditorViewportInstanceSettingsKeyValuePair() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLevelEditorViewportInstanceSettingsKeyValuePair A, FLevelEditorViewportInstanceSettingsKeyValuePair B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLevelEditorViewportInstanceSettingsKeyValuePair A, FLevelEditorViewportInstanceSettingsKeyValuePair B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLevelEditorViewportInstanceSettingsKeyValuePair;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString ConfigName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ConfigName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ConfigName, __InBuffer);
				}
			}
		}

		public FLevelEditorViewportInstanceSettings ConfigSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ConfigSettings, __ReturnBuffer);

					return *(FLevelEditorViewportInstanceSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ConfigSettings, __InBuffer);
				}
			}
		}

		private static uint __ConfigName = 0;

		private static uint __ConfigSettings = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}