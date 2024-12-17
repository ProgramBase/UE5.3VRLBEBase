using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ActorComponentInstanceData")]
	public partial class FActorComponentInstanceData : FInstanceCacheDataBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.ActorComponentInstanceData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FActorComponentInstanceData()
		{
		}

		public static bool operator ==(FActorComponentInstanceData A, FActorComponentInstanceData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FActorComponentInstanceData A, FActorComponentInstanceData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FActorComponentInstanceData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UObject SourceComponentTemplate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SourceComponentTemplate, __ReturnBuffer);

					return *(UObject*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SourceComponentTemplate, __InBuffer);
				}
			}
		}

		public EComponentCreationMethod SourceComponentCreationMethod
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SourceComponentCreationMethod, __ReturnBuffer);

					return *(EComponentCreationMethod*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SourceComponentCreationMethod, __InBuffer);
				}
			}
		}

		public int SourceComponentTypeSerializedIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SourceComponentTypeSerializedIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SourceComponentTypeSerializedIndex, __InBuffer);
				}
			}
		}

		private static uint __SourceComponentTemplate = 0;

		private static uint __SourceComponentCreationMethod = 0;

		private static uint __SourceComponentTypeSerializedIndex = 0;

	}
}