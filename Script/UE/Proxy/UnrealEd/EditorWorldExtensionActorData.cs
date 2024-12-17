using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EditorWorldExtensionActorData")]
	public partial class FEditorWorldExtensionActorData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UnrealEd.EditorWorldExtensionActorData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEditorWorldExtensionActorData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FEditorWorldExtensionActorData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FEditorWorldExtensionActorData A, FEditorWorldExtensionActorData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEditorWorldExtensionActorData A, FEditorWorldExtensionActorData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEditorWorldExtensionActorData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public AActor Actor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Actor, __ReturnBuffer);

					return *(AActor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Actor, __InBuffer);
				}
			}
		}

		public bool bValidForPIE
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bValidForPIE, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bValidForPIE, __InBuffer);
				}
			}
		}

		private static uint __Actor = 0;

		private static uint __bValidForPIE = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}