using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.CreateActorParams")]
	public partial class FCreateActorParams : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ModelingComponents.CreateActorParams");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCreateActorParams() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCreateActorParams() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCreateActorParams A, FCreateActorParams B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCreateActorParams A, FCreateActorParams B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCreateActorParams;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UWorld TargetWorld
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TargetWorld, __ReturnBuffer);

					return *(UWorld*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TargetWorld, __InBuffer);
				}
			}
		}

		public FString BaseName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BaseName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BaseName, __InBuffer);
				}
			}
		}

		public FTransform Transform
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Transform, __ReturnBuffer);

					return *(FTransform*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Transform, __InBuffer);
				}
			}
		}

		public AActor TemplateActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TemplateActor, __ReturnBuffer);

					return *(AActor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TemplateActor, __InBuffer);
				}
			}
		}

		private static uint __TargetWorld = 0;

		private static uint __BaseName = 0;

		private static uint __Transform = 0;

		private static uint __TemplateActor = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}