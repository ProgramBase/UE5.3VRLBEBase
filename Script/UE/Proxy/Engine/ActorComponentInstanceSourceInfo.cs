using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ActorComponentInstanceSourceInfo")]
	public partial class FActorComponentInstanceSourceInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.ActorComponentInstanceSourceInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FActorComponentInstanceSourceInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FActorComponentInstanceSourceInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FActorComponentInstanceSourceInfo A, FActorComponentInstanceSourceInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FActorComponentInstanceSourceInfo A, FActorComponentInstanceSourceInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FActorComponentInstanceSourceInfo;

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

		public nint GarbageCollectionHandle { get; set; }
	}
}