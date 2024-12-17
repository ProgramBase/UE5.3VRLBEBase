using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneEvent")]
	public partial class FMovieSceneEvent : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieSceneTracks.MovieSceneEvent");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneEvent() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneEvent() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneEvent A, FMovieSceneEvent B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneEvent A, FMovieSceneEvent B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneEvent;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FMovieSceneEventPtrs Ptrs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Ptrs, __ReturnBuffer);

					return *(FMovieSceneEventPtrs*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Ptrs, __InBuffer);
				}
			}
		}

		public TMap<FName, FMovieSceneEventPayloadVariable> PayloadVariables
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PayloadVariables, __ReturnBuffer);

					return *(TMap<FName, FMovieSceneEventPayloadVariable>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PayloadVariables, __InBuffer);
				}
			}
		}

		public FName CompiledFunctionName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CompiledFunctionName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CompiledFunctionName, __InBuffer);
				}
			}
		}

		public FName BoundObjectPinName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BoundObjectPinName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BoundObjectPinName, __InBuffer);
				}
			}
		}

		public TWeakObjectPtr<UObject> WeakEndpoint
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __WeakEndpoint, __ReturnBuffer);

					return *(TWeakObjectPtr<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __WeakEndpoint, __InBuffer);
				}
			}
		}

		private static uint __Ptrs = 0;

		private static uint __PayloadVariables = 0;

		private static uint __CompiledFunctionName = 0;

		private static uint __BoundObjectPinName = 0;

		private static uint __WeakEndpoint = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}