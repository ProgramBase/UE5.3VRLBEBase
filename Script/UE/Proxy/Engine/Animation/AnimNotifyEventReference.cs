using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimNotifyEventReference")]
	public partial class FAnimNotifyEventReference : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AnimNotifyEventReference");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimNotifyEventReference() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAnimNotifyEventReference() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAnimNotifyEventReference A, FAnimNotifyEventReference B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimNotifyEventReference A, FAnimNotifyEventReference B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimNotifyEventReference;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UMirrorDataTable MirrorTable
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MirrorTable, __ReturnBuffer);

					return *(UMirrorDataTable*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MirrorTable, __InBuffer);
				}
			}
		}

		public UObject NotifySource
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NotifySource, __ReturnBuffer);

					return *(UObject*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NotifySource, __InBuffer);
				}
			}
		}

		private static uint __MirrorTable = 0;

		private static uint __NotifySource = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}