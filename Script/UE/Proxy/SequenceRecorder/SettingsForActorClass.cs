using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.SequenceRecorder
{
	[PathName("/Script/SequenceRecorder.SettingsForActorClass")]
	public partial class FSettingsForActorClass : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/SequenceRecorder.SettingsForActorClass");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSettingsForActorClass() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSettingsForActorClass() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSettingsForActorClass A, FSettingsForActorClass B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSettingsForActorClass A, FSettingsForActorClass B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSettingsForActorClass;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TSubclassOf<AActor> Class
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Class, __ReturnBuffer);

					return *(TSubclassOf<AActor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Class, __InBuffer);
				}
			}
		}

		public bool bRecordToPossessable
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bRecordToPossessable, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bRecordToPossessable, __InBuffer);
				}
			}
		}

		private static uint __Class = 0;

		private static uint __bRecordToPossessable = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}