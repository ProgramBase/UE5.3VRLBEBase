using Script.CoreUObject;
using Script.Library;
using Script.InterchangeNodes;

namespace Script.InterchangePipelines
{
	[PathName("/Script/InterchangePipelines.InterchangeLodSceneNodeContainer")]
	public partial class FInterchangeLodSceneNodeContainer : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/InterchangePipelines.InterchangeLodSceneNodeContainer");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FInterchangeLodSceneNodeContainer() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FInterchangeLodSceneNodeContainer() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FInterchangeLodSceneNodeContainer A, FInterchangeLodSceneNodeContainer B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FInterchangeLodSceneNodeContainer A, FInterchangeLodSceneNodeContainer B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FInterchangeLodSceneNodeContainer;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<UInterchangeSceneNode> SceneNodes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SceneNodes, __ReturnBuffer);

					return *(TArray<UInterchangeSceneNode>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SceneNodes, __InBuffer);
				}
			}
		}

		private static uint __SceneNodes = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}