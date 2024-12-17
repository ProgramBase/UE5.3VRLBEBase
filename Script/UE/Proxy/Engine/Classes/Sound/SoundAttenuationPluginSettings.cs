using Script.CoreUObject;
using Script.Library;
using Script.AudioExtensions;

namespace Script.Engine
{
	[PathName("/Script/Engine.SoundAttenuationPluginSettings")]
	public partial class FSoundAttenuationPluginSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.SoundAttenuationPluginSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSoundAttenuationPluginSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSoundAttenuationPluginSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSoundAttenuationPluginSettings A, FSoundAttenuationPluginSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSoundAttenuationPluginSettings A, FSoundAttenuationPluginSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSoundAttenuationPluginSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<USpatializationPluginSourceSettingsBase> SpatializationPluginSettingsArray
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SpatializationPluginSettingsArray, __ReturnBuffer);

					return *(TArray<USpatializationPluginSourceSettingsBase>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SpatializationPluginSettingsArray, __InBuffer);
				}
			}
		}

		public TArray<UOcclusionPluginSourceSettingsBase> OcclusionPluginSettingsArray
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OcclusionPluginSettingsArray, __ReturnBuffer);

					return *(TArray<UOcclusionPluginSourceSettingsBase>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OcclusionPluginSettingsArray, __InBuffer);
				}
			}
		}

		public TArray<UReverbPluginSourceSettingsBase> ReverbPluginSettingsArray
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ReverbPluginSettingsArray, __ReturnBuffer);

					return *(TArray<UReverbPluginSourceSettingsBase>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ReverbPluginSettingsArray, __InBuffer);
				}
			}
		}

		public TArray<USourceDataOverridePluginSourceSettingsBase> SourceDataOverridePluginSettingsArray
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SourceDataOverridePluginSettingsArray, __ReturnBuffer);

					return *(TArray<USourceDataOverridePluginSourceSettingsBase>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SourceDataOverridePluginSettingsArray, __InBuffer);
				}
			}
		}

		private static uint __SpatializationPluginSettingsArray = 0;

		private static uint __OcclusionPluginSettingsArray = 0;

		private static uint __ReverbPluginSettingsArray = 0;

		private static uint __SourceDataOverridePluginSettingsArray = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}