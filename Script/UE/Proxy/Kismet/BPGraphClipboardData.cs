using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.Kismet
{
	[PathName("/Script/Kismet.BPGraphClipboardData")]
	public partial class FBPGraphClipboardData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Kismet.BPGraphClipboardData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBPGraphClipboardData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FBPGraphClipboardData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FBPGraphClipboardData A, FBPGraphClipboardData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBPGraphClipboardData A, FBPGraphClipboardData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBPGraphClipboardData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName GraphName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GraphName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GraphName, __InBuffer);
				}
			}
		}

		public EGraphType GraphType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GraphType, __ReturnBuffer);

					return *(EGraphType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GraphType, __InBuffer);
				}
			}
		}

		public TWeakObjectPtr<UBlueprint> OriginalBlueprint
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OriginalBlueprint, __ReturnBuffer);

					return *(TWeakObjectPtr<UBlueprint>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OriginalBlueprint, __InBuffer);
				}
			}
		}

		public FString NodesString
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NodesString, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NodesString, __InBuffer);
				}
			}
		}

		private static uint __GraphName = 0;

		private static uint __GraphType = 0;

		private static uint __OriginalBlueprint = 0;

		private static uint __NodesString = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}