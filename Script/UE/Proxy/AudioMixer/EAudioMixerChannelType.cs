﻿using Script.CoreUObject;

namespace Script.AudioMixer
{
	[PathName("/Script/AudioMixer.EAudioMixerChannelType")]
	public enum EAudioMixerChannelType : byte
	{
		FrontLeft = 0,
		FrontRight = 1,
		FrontCenter = 2,
		LowFrequency = 3,
		BackLeft = 4,
		BackRight = 5,
		FrontLeftOfCenter = 6,
		FrontRightOfCenter = 7,
		BackCenter = 8,
		SideLeft = 9,
		SideRight = 10,
		TopCenter = 11,
		TopFrontLeft = 12,
		TopFrontCenter = 13,
		TopFrontRight = 14,
		TopBackLeft = 15,
		TopBackCenter = 16,
		TopBackRight = 17,
		Unknown = 18,
		ChannelTypeCount = 19,
		DefaultChannel = 0,
	}
}