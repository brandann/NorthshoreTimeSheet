Filter_Ambfilt_Service_Inst]
ServiceType   = 1                  ; SERVICE_KERNEL_DRIVER
StartType     = 3                  ; SERVICE_DEMAND_START
ErrorControl  = 1                  ; SERVICE_ERROR_NORMAL
ServiceBinary = %10%\system32\drivers\Ambft64.sys

[Filter_Monfilt_Service_Inst]
ServiceType   = 1                  ; SERVICE_KERNEL_DRIVER
StartType     = 3                  ; SERVICE_DEMAND_START
ErrorControl  = 1                  ; SERVICE_ERROR_NORMAL
ServiceBinary = %10%\system32\drivers\Monft64.sys

[IntcAzAudModel.NTamd64.Interfaces]
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_DigitalMICWave%, IntcAzAudModel.DigitalMICWave
AddInterface=%KSCATEGORY_RENDER%,%KSNAME_DigitalMICWave%, IntcAzAudModel.DigitalMICWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_DigitalMICTopo%, IntcAzAudModel.DigitalMICTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_DigitalMICTopo%, IntcAzAudModel.DigitalMICTopo

AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearLineOutWave%, IntcAzAudModel.RearLineOutWave
AddInterface=%KSCATEGORY_RENDER%,%KSNAME_RearLineOutWave%, IntcAzAudModel.RearLineOutWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearLineOutTopo%, IntcAzAudModel.RearLineOutTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_RearLineOutTopo%, IntcAzAudModel.RearLineOutTopo

AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_PrimaryLineOutWave%, IntcAzAudModel.PrimaryLineOutWave
AddInterface=%KSCATEGORY_RENDER%,%KSNAME_PrimaryLineOutWave%, IntcAzAudModel.PrimaryLineOutWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_PrimaryLineOutTopo%, IntcAzAudModel.PrimaryLineOutTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_PrimaryLineOutTopo%, IntcAzAudModel.PrimaryLineOutTopo

AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_SingleLineOutWave%, IntcAzAudModel.SingleLineOutWave
AddInterface=%KSCATEGORY_RENDER%,%KSNAME_SingleLineOutWave%, IntcAzAudModel.SingleLineOutWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_SingleLineOutTopo%, IntcAzAudModel.SingleLineOutTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_SingleLineOutTopo%, IntcAzAudModel.SingleLineOutTopo

AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontSpeakerWave%, IntcAzAudModel.FrontSpeakerWave
AddInterface=%KSCATEGORY_RENDER%,%KSNAME_FrontSpeakerWave%, IntcAzAudModel.FrontSpeakerWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontSpeakeTopo%, IntcAzAudModel.FrontSpeakeTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_FrontSpeakeTopo%, IntcAzAudModel.FrontSpeakeTopo

AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_SingleLineInWave%, IntcAzAudModel.SingleLineInWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_SingleLineInWave%, IntcAzAudModel.SingleLineInWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_SingleLineInTopo%, IntcAzAudModel.SingleLineInTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_SingleLineInTopo%, IntcAzAudModel.SingleLineInTopo

AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_SecondaryLineOutWave%, IntcAzAudModel.SecondaryLineOutWave
AddInterface=%KSCATEGORY_RENDER%,%KSNAME_SecondaryLineOutWave%, IntcAzAudModel.SecondaryLineOutWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_SecondaryLineOutTopo%, IntcAzAudModel.SecondaryLineOutTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_SecondaryLineOutTopo%, IntcAzAudModel.SecondaryLineOutTopo

AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearSpeakerWave%, IntcAzAudModel.RearSpeakerWave
AddInterface=%KSCATEGORY_RENDER%,%KSNAME_RearSpeakerWave%, IntcAzAudModel.RearSpeakerWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearSpeakerTopo%, IntcAzAudModel.RearSpeakerTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_RearSpeakerTopo%, IntcAzAudModel.RearSpeakerTopo

AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearLineInWave%, IntcAzAudModel.RearLineInWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_RearLineInWave%, IntcAzAudModel.RearLineInWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearLineInTopo%, IntcAzAudModel.RearLineInTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_RearLineInTopo%, IntcAzAudModel.RearLineInTopo

AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_SecondaryLineInWave%, IntcAzAudModel.SecondaryLineInWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_SecondaryLineInWave%, IntcAzAudModel.SecondaryLineInWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_SecondaryLineInTopo%, IntcAzAudModel.SecondaryLineInTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_SecondaryLineInTopo%, IntcAzAudModel.SecondaryLineInTopo

AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_PrimaryLineInWave%, IntcAzAudModel.PrimaryLineInWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_PrimaryLineInWave%, IntcAzAudModel.PrimaryLineInWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_PrimaryLineInTopo%, IntcAzAudModel.PrimaryLineInTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_PrimaryLineInTopo%, IntcAzAudModel.PrimaryLineInTopo

AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_HPRearCaptureWave%, IntcAzAudModel.HPRearCaptureWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_HPRearCaptureWave%, IntcAzAudModel.HPRearCaptureWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_HPRearCaptureTopo%, IntcAzAudModel.HPRearCaptureTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_HPRearCaptureTopo%, IntcAzAudModel.HPRearCaptureTopo

AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_HPRearCaptureWave_XFLineIn%, IntcAzAudModel.HPRearCaptureWave_XFLineIn
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_HPRearCaptureWave_XFLineIn%, IntcAzAudModel.HPRearCaptureWave_XFLineIn
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_HPRearCaptureTopo_XFLineIn%, IntcAzAudModel.HPRearCaptureTopo_XFLineIn
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_HPRearCaptureTopo_XFLineIn%, IntcAzAudModel.HPRearCaptureTopo_XFLineIn

AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_HPCPCCaptureWave%, IntcAzAudModel.HPCPCCaptureWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_HPCPCCaptureWave%, IntcAzAudModel.HPCPCCaptureWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_HPCPCCaptureTopo%, IntcAzAudModel.HPCPCCaptureTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_HPCPCCaptureTopo%, IntcAzAudModel.HPCPCCaptureTopo

AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontPanelHeadphoneWave%, IntcAzAudModel.FrontPanelHeadphoneWave
AddInterface=%KSCATEGORY_RENDER%,%KSNAME_FrontPanelHeadphoneWave%, IntcAzAudModel.FrontPanelHeadphoneWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontPanelHeadphoneTopo%, IntcAzAudModel.FrontPanelHeadphoneTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_FrontPanelHeadphoneTopo%, IntcAzAudModel.FrontPanelHeadphoneTopo

AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontPanelMicWave%, IntcAzAudModel.FrontPanelMicWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_FrontPanelMicWave%, IntcAzAudModel.FrontPanelMicWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontPanelMicTopo%, IntcAzAudModel.FrontPanelMicTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_FrontPanelMicTopo%, IntcAzAudModel.FrontPanelMicTopo

AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_DigitalOutputWave%, IntcAzAudModel.DigitalOutputWave
AddInterface=%KSCATEGORY_RENDER%,%KSNAME_DigitalOutputWave%, IntcAzAudModel.DigitalOutputWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_DigitalOutputTopo%, IntcAzAudModel.DigitalOutputTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_DigitalOutputTopo%, IntcAzAudModel.DigitalOutputTopo

AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_DigitalInputWave%, IntcAzAudModel.DigitalInputWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_DigitalInputWave%, IntcAzAudModel.DigitalInputWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_DigitalInputTopo%, IntcAzAudModel.DigitalInputTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_DigitalInputTopo%, IntcAzAudModel.DigitalInputTopo

AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_AecArrayMicInWave%, IntcAzAudModel.AecArrayMicInWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_AecArrayMicInWave%, IntcAzAudModel.AecArrayMicInWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_AecArrayMicInTopo%, IntcAzAudModel.AecArrayMicInTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_AecArrayMicInTopo%, IntcAzAudModel.AecArrayMicInTopo

AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontMic2UAJWave%, IntcAzAudModel.FrontMic2UAJWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_FrontMic2UAJWave%, IntcAzAudModel.FrontMic2UAJWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontMic2UAJTopo%, IntcAzAudModel.FrontMic2UAJTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_FrontMic2UAJTopo%, IntcAzAudModel.FrontMic2UAJTopo

AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontLine2UAJWave%, IntcAzAudModel.FrontLine2UAJWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_FrontLine2UAJWave%, IntcAzAudModel.FrontLine2UAJWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontLine2UAJTopo%, IntcAzAudModel.FrontLine2UAJTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_FrontLine2UAJTopo%, IntcAzAudModel.FrontLine2UAJTopo

AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearFrontOutWave%, IntcAzAudModel.RearFrontOutWave
AddInterface=%KSCATEGORY_RENDER%,%KSNAME_RearFrontOutWave%, IntcAzAudModel.RearFrontOutWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearFrontOutTopo%, IntcAzAudModel.RearFrontOutTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_RearFrontOutTopo%, IntcAzAudModel.RearFrontOutTopo

AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearFrontInWave%, IntcAzAudModel.RearFrontInWave
AddInterface=%KSCATEGORY_RENDER%,%KSNAME_RearFrontInWave%, IntcAzAudModel.RearFrontInWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearFrontInTopo%, IntcAzAudModel.RearFrontInTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_RearFrontInTopo%, IntcAzAudModel.RearFrontInTopo

;=================Skype======================
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_SkypeLineInWave%, IntcAzAudModel.SkypeLineInWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_SkypeLineInWave%, IntcAzAudModel.SkypeLineInWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_SKypeLineInTopo%, IntcAzAudModel.SkypeLineInTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_SKypeLineInTopo%, IntcAzAudModel.SkypeLineInTopo

AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_SkypeLineOutWave%, IntcAzAudModel.SkypeLineOutWave
AddInterface=%KSCATEGORY_RENDER%,%KSNAME_SkypeLineOutWave%, IntcAzAudModel.SkypeLineOutWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_SKypeLineOutTopo%, IntcAzAudModel.SkypeLineOutTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_SKypeLineOutTopo%, IntcAzAudModel.SkypeLineOutTopo


AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_SkypeVoiceWave%, IntcAzAudModel.SkypeVoiceWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_SkypeVoiceWave%, IntcAzAudModel.SkypeVoiceWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_SKypeVoiceTopo%, IntcAzAudModel.SkypeVoiceTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_SKypeVoiceTopo%, IntcAzAudModel.SkypeVoiceTopo

AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_SkypeVoiceInWave%, IntcAzAudModel.SkypeVoiceInWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_SkypeVoiceInWave%, IntcAzAudModel.SkypeVoiceInWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_SkypeVoiceInTopo%, IntcAzAudModel.SkypeVoiceInTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_SkypeVoiceInTopo%, IntcAzAudModel.SkypeVoiceInTopo


;;===========================================NewFrameWork======================================================
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearLineInBlackWave%, IntcAzAudModel.RearLineInBlackWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_RearLineInBlackWave%, IntcAzAudModel.RearLineInBlackWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearLineInBlackTopo%, IntcAzAudModel.RearLineInBlackTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_RearLineInBlackTopo%, IntcAzAudModel.RearLineInBlackTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearLineInGreyWave%, IntcAzAudModel.RearLineInGreyWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_RearLineInGreyWave%, IntcAzAudModel.RearLineInGreyWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearLineInGreyTopo%, IntcAzAudModel.RearLineInGreyTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_RearLineInGreyTopo%, IntcAzAudModel.RearLineInGreyTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearLineInBlueWave%, IntcAzAudModel.RearLineInBlueWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_RearLineInBlueWave%, IntcAzAudModel.RearLineInBlueWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearLineInBlueTopo%, IntcAzAudModel.RearLineInBlueTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_RearLineInBlueTopo%, IntcAzAudModel.RearLineInBlueTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearLineInGreenWave%, IntcAzAudModel.RearLineInGreenWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_RearLineInGreenWave%, IntcAzAudModel.RearLineInGreenWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearLineInGreenTopo%, IntcAzAudModel.RearLineInGreenTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_RearLineInGreenTopo%, IntcAzAudModel.RearLineInGreenTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearLineInRedWave%, IntcAzAudModel.RearLineInRedWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_RearLineInRedWave%, IntcAzAudModel.RearLineInRedWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearLineInRedTopo%, IntcAzAudModel.RearLineInRedTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_RearLineInRedTopo%, IntcAzAudModel.RearLineInRedTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearLineInOrangeWave%, IntcAzAudModel.RearLineInOrangeWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_RearLineInOrangeWave%, IntcAzAudModel.RearLineInOrangeWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearLineInOrangeTopo%, IntcAzAudModel.RearLineInOrangeTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_RearLineInOrangeTopo%, IntcAzAudModel.RearLineInOrangeTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearLineInYellowWave%, IntcAzAudModel.RearLineInYellowWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_RearLineInYellowWave%, IntcAzAudModel.RearLineInYellowWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearLineInYellowTopo%, IntcAzAudModel.RearLineInYellowTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_RearLineInYellowTopo%, IntcAzAudModel.RearLineInYellowTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearLineInPurpleWave%, IntcAzAudModel.RearLineInPurpleWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_RearLineInPurpleWave%, IntcAzAudModel.RearLineInPurpleWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearLineInPurpleTopo%, IntcAzAudModel.RearLineInPurpleTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_RearLineInPurpleTopo%, IntcAzAudModel.RearLineInPurpleTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearLineInPinkWave%, IntcAzAudModel.RearLineInPinkWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_RearLineInPinkWave%, IntcAzAudModel.RearLineInPinkWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearLineInPinkTopo%, IntcAzAudModel.RearLineInPinkTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_RearLineInPinkTopo%, IntcAzAudModel.RearLineInPinkTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearLineInGoldenWave%, IntcAzAudModel.RearLineInGoldenWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_RearLineInGoldenWave%, IntcAzAudModel.RearLineInGoldenWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearLineInGoldenTopo%, IntcAzAudModel.RearLineInGoldenTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_RearLineInGoldenTopo%, IntcAzAudModel.RearLineInGoldenTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearLineInSilverWave%, IntcAzAudModel.RearLineInSilverWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_RearLineInSilverWave%, IntcAzAudModel.RearLineInSilverWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearLineInSilverTopo%, IntcAzAudModel.RearLineInSilverTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_RearLineInSilverTopo%, IntcAzAudModel.RearLineInSilverTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearLineInWhiteWave%, IntcAzAudModel.RearLineInWhiteWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_RearLineInWhiteWave%, IntcAzAudModel.RearLineInWhiteWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearLineInWhiteTopo%, IntcAzAudModel.RearLineInWhiteTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_RearLineInWhiteTopo%, IntcAzAudModel.RearLineInWhiteTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearMicInBlackWave%, IntcAzAudModel.RearMicInBlackWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_RearMicInBlackWave%, IntcAzAudModel.RearMicInBlackWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearMicInBlackTopo%, IntcAzAudModel.RearMicInBlackTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_RearMicInBlackTopo%, IntcAzAudModel.RearMicInBlackTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearMicInGreyWave%, IntcAzAudModel.RearMicInGreyWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_RearMicInGreyWave%, IntcAzAudModel.RearMicInGreyWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearMicInGreyTopo%, IntcAzAudModel.RearMicInGreyTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_RearMicInGreyTopo%, IntcAzAudModel.RearMicInGreyTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearMicInBlueWave%, IntcAzAudModel.RearMicInBlueWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_RearMicInBlueWave%, IntcAzAudModel.RearMicInBlueWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearMicInBlueTopo%, IntcAzAudModel.RearMicInBlueTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_RearMicInBlueTopo%, IntcAzAudModel.RearMicInBlueTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearMicInGreenWave%, IntcAzAudModel.RearMicInGreenWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_RearMicInGreenWave%, IntcAzAudModel.RearMicInGreenWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearMicInGreenTopo%, IntcAzAudModel.RearMicInGreenTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_RearMicInGreenTopo%, IntcAzAudModel.RearMicInGreenTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearMicInRedWave%, IntcAzAudModel.RearMicInRedWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_RearMicInRedWave%, IntcAzAudModel.RearMicInRedWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearMicInRedTopo%, IntcAzAudModel.RearMicInRedTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_RearMicInRedTopo%, IntcAzAudModel.RearMicInRedTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearMicInOrangeWave%, IntcAzAudModel.RearMicInOrangeWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_RearMicInOrangeWave%, IntcAzAudModel.RearMicInOrangeWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearMicInOrangeTopo%, IntcAzAudModel.RearMicInOrangeTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_RearMicInOrangeTopo%, IntcAzAudModel.RearMicInOrangeTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearMicInYellowWave%, IntcAzAudModel.RearMicInYellowWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_RearMicInYellowWave%, IntcAzAudModel.RearMicInYellowWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearMicInYellowTopo%, IntcAzAudModel.RearMicInYellowTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_RearMicInYellowTopo%, IntcAzAudModel.RearMicInYellowTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearMicInPurpleWave%, IntcAzAudModel.RearMicInPurpleWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_RearMicInPurpleWave%, IntcAzAudModel.RearMicInPurpleWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearMicInPurpleTopo%, IntcAzAudModel.RearMicInPurpleTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_RearMicInPurpleTopo%, IntcAzAudModel.RearMicInPurpleTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearMicInPinkWave%, IntcAzAudModel.RearMicInPinkWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_RearMicInPinkWave%, IntcAzAudModel.RearMicInPinkWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearMicInPinkTopo%, IntcAzAudModel.RearMicInPinkTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_RearMicInPinkTopo%, IntcAzAudModel.RearMicInPinkTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearMicInGoldenWave%, IntcAzAudModel.RearMicInGoldenWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_RearMicInGoldenWave%, IntcAzAudModel.RearMicInGoldenWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearMicInGoldenTopo%, IntcAzAudModel.RearMicInGoldenTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_RearMicInGoldenTopo%, IntcAzAudModel.RearMicInGoldenTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearMicInSilverWave%, IntcAzAudModel.RearMicInSilverWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_RearMicInSilverWave%, IntcAzAudModel.RearMicInSilverWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearMicInSilverTopo%, IntcAzAudModel.RearMicInSilverTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_RearMicInSilverTopo%, IntcAzAudModel.RearMicInSilverTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearMicInWhiteWave%, IntcAzAudModel.RearMicInWhiteWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_RearMicInWhiteWave%, IntcAzAudModel.RearMicInWhiteWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearMicInWhiteTopo%, IntcAzAudModel.RearMicInWhiteTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_RearMicInWhiteTopo%, IntcAzAudModel.RearMicInWhiteTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontLineInBlackWave%, IntcAzAudModel.FrontLineInBlackWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_FrontLineInBlackWave%, IntcAzAudModel.FrontLineInBlackWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontLineInBlackTopo%, IntcAzAudModel.FrontLineInBlackTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_FrontLineInBlackTopo%, IntcAzAudModel.FrontLineInBlackTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontLineInGreyWave%, IntcAzAudModel.FrontLineInGreyWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_FrontLineInGreyWave%, IntcAzAudModel.FrontLineInGreyWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontLineInGreyTopo%, IntcAzAudModel.FrontLineInGreyTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_FrontLineInGreyTopo%, IntcAzAudModel.FrontLineInGreyTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontLineInBlueWave%, IntcAzAudModel.FrontLineInBlueWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_FrontLineInBlueWave%, IntcAzAudModel.FrontLineInBlueWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontLineInBlueTopo%, IntcAzAudModel.FrontLineInBlueTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_FrontLineInBlueTopo%, IntcAzAudModel.FrontLineInBlueTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontLineInGreenWave%, IntcAzAudModel.FrontLineInGreenWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_FrontLineInGreenWave%, IntcAzAudModel.FrontLineInGreenWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontLineInGreenTopo%, IntcAzAudModel.FrontLineInGreenTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_FrontLineInGreenTopo%, IntcAzAudModel.FrontLineInGreenTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontLineInRedWave%, IntcAzAudModel.FrontLineInRedWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_FrontLineInRedWave%, IntcAzAudModel.FrontLineInRedWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontLineInRedTopo%, IntcAzAudModel.FrontLineInRedTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_FrontLineInRedTopo%, IntcAzAudModel.FrontLineInRedTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontLineInOrangeWave%, IntcAzAudModel.FrontLineInOrangeWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_FrontLineInOrangeWave%, IntcAzAudModel.FrontLineInOrangeWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontLineInOrangeTopo%, IntcAzAudModel.FrontLineInOrangeTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_FrontLineInOrangeTopo%, IntcAzAudModel.FrontLineInOrangeTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontLineInYellowWave%, IntcAzAudModel.FrontLineInYellowWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_FrontLineInYellowWave%, IntcAzAudModel.FrontLineInYellowWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontLineInYellowTopo%, IntcAzAudModel.FrontLineInYellowTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_FrontLineInYellowTopo%, IntcAzAudModel.FrontLineInYellowTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontLineInPurpleWave%, IntcAzAudModel.FrontLineInPurpleWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_FrontLineInPurpleWave%, IntcAzAudModel.FrontLineInPurpleWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontLineInPurpleTopo%, IntcAzAudModel.FrontLineInPurpleTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_FrontLineInPurpleTopo%, IntcAzAudModel.FrontLineInPurpleTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontLineInPinkWave%, IntcAzAudModel.FrontLineInPinkWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_FrontLineInPinkWave%, IntcAzAudModel.FrontLineInPinkWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontLineInPinkTopo%, IntcAzAudModel.FrontLineInPinkTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_FrontLineInPinkTopo%, IntcAzAudModel.FrontLineInPinkTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontLineInGoldenWave%, IntcAzAudModel.FrontLineInGoldenWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_FrontLineInGoldenWave%, IntcAzAudModel.FrontLineInGoldenWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontLineInGoldenTopo%, IntcAzAudModel.FrontLineInGoldenTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_FrontLineInGoldenTopo%, IntcAzAudModel.FrontLineInGoldenTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontLineInSilverWave%, IntcAzAudModel.FrontLineInSilverWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_FrontLineInSilverWave%, IntcAzAudModel.FrontLineInSilverWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontLineInSilverTopo%, IntcAzAudModel.FrontLineInSilverTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_FrontLineInSilverTopo%, IntcAzAudModel.FrontLineInSilverTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontLineInWhiteWave%, IntcAzAudModel.FrontLineInWhiteWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_FrontLineInWhiteWave%, IntcAzAudModel.FrontLineInWhiteWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontLineInWhiteTopo%, IntcAzAudModel.FrontLineInWhiteTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_FrontLineInWhiteTopo%, IntcAzAudModel.FrontLineInWhiteTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontMicInBlackWave%, IntcAzAudModel.FrontMicInBlackWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_FrontMicInBlackWave%, IntcAzAudModel.FrontMicInBlackWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontMicInBlackTopo%, IntcAzAudModel.FrontMicInBlackTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_FrontMicInBlackTopo%, IntcAzAudModel.FrontMicInBlackTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontMicInGreyWave%, IntcAzAudModel.FrontMicInGreyWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_FrontMicInGreyWave%, IntcAzAudModel.FrontMicInGreyWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontMicInGreyTopo%, IntcAzAudModel.FrontMicInGreyTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_FrontMicInGreyTopo%, IntcAzAudModel.FrontMicInGreyTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontMicInBlueWave%, IntcAzAudModel.FrontMicInBlueWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_FrontMicInBlueWave%, IntcAzAudModel.FrontMicInBlueWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontMicInBlueTopo%, IntcAzAudModel.FrontMicInBlueTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_FrontMicInBlueTopo%, IntcAzAudModel.FrontMicInBlueTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontMicInGreenWave%, IntcAzAudModel.FrontMicInGreenWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_FrontMicInGreenWave%, IntcAzAudModel.FrontMicInGreenWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontMicInGreenTopo%, IntcAzAudModel.FrontMicInGreenTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_FrontMicInGreenTopo%, IntcAzAudModel.FrontMicInGreenTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontMicInRedWave%, IntcAzAudModel.FrontMicInRedWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_FrontMicInRedWave%, IntcAzAudModel.FrontMicInRedWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontMicInRedTopo%, IntcAzAudModel.FrontMicInRedTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_FrontMicInRedTopo%, IntcAzAudModel.FrontMicInRedTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontMicInOrangeWave%, IntcAzAudModel.FrontMicInOrangeWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_FrontMicInOrangeWave%, IntcAzAudModel.FrontMicInOrangeWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontMicInOrangeTopo%, IntcAzAudModel.FrontMicInOrangeTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_FrontMicInOrangeTopo%, IntcAzAudModel.FrontMicInOrangeTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontMicInYellowWave%, IntcAzAudModel.FrontMicInYellowWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_FrontMicInYellowWave%, IntcAzAudModel.FrontMicInYellowWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontMicInYellowTopo%, IntcAzAudModel.FrontMicInYellowTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_FrontMicInYellowTopo%, IntcAzAudModel.FrontMicInYellowTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontMicInPurpleWave%, IntcAzAudModel.FrontMicInPurpleWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_FrontMicInPurpleWave%, IntcAzAudModel.FrontMicInPurpleWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontMicInPurpleTopo%, IntcAzAudModel.FrontMicInPurpleTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_FrontMicInPurpleTopo%, IntcAzAudModel.FrontMicInPurpleTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontMicInPinkWave%, IntcAzAudModel.FrontMicInPinkWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_FrontMicInPinkWave%, IntcAzAudModel.FrontMicInPinkWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontMicInPinkTopo%, IntcAzAudModel.FrontMicInPinkTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_FrontMicInPinkTopo%, IntcAzAudModel.FrontMicInPinkTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontMicInGoldenWave%, IntcAzAudModel.FrontMicInGoldenWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_FrontMicInGoldenWave%, IntcAzAudModel.FrontMicInGoldenWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontMicInGoldenTopo%, IntcAzAudModel.FrontMicInGoldenTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_FrontMicInGoldenTopo%, IntcAzAudModel.FrontMicInGoldenTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontMicInSilverWave%, IntcAzAudModel.FrontMicInSilverWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_FrontMicInSilverWave%, IntcAzAudModel.FrontMicInSilverWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontMicInSilverTopo%, IntcAzAudModel.FrontMicInSilverTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_FrontMicInSilverTopo%, IntcAzAudModel.FrontMicInSilverTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontMicInWhiteWave%, IntcAzAudModel.FrontMicInWhiteWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_FrontMicInWhiteWave%, IntcAzAudModel.FrontMicInWhiteWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontMicInWhiteTopo%, IntcAzAudModel.FrontMicInWhiteTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_FrontMicInWhiteTopo%, IntcAzAudModel.FrontMicInWhiteTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontMicWave%, IntcAzAudModel.FrontMicWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_FrontMicWave%, IntcAzAudModel.FrontMicWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FrontMicTopo%, IntcAzAudModel.FrontMicTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_FrontMicTopo%, IntcAzAudModel.FrontMicTopo
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearMicWave%, IntcAzAudModel.RearMicWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_RearMicWave%, IntcAzAudModel.RearMicWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RearMicTopo%, IntcAzAudModel.RearMicTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_RearMicTopo%, IntcAzAudModel.RearMicTopo

AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FjIntrMICWave%, IntcAzAudModel.FjIntrMICWave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_FjIntrMICWave%, IntcAzAudModel.FjIntrMICWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FjMic1Wave%, IntcAzAudModel.FjMic1Wave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_FjMic1Wave%, IntcAzAudModel.FjMic1Wave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_FjLineIn1Wave%, IntcAzAudModel.FjLineIn1Wave
AddInterface=%KSCATEGORY_CAPTURE%,%KSNAME_FjLineIn1Wave%, IntcAzAudModel.FjLineIn1Wave

AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RtSpdifWave%, IntcAzAudModel.RtSpdifWave
AddInterface=%KSCATEGORY_RENDER%,%KSNAME_RtSpdifWave%, IntcAzAudModel.RtSpdifWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RtSpdifTopo%, IntcAzAudModel.RtSpdifTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_RtSpdifTopo%, IntcAzAudModel.RtSpdifTopo

AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RtSpdifHDMIWave%, IntcAzAudModel.RtSpdifHDMIWave
AddInterface=%KSCATEGORY_RENDER%,%KSNAME_RtSpdifHDMIWave%, IntcAzAudModel.RtSpdifHDMIWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RtSpdifHDMITopo%, IntcAzAudModel.RtSpdifHDMITopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_RtSpdifHDMITopo%, IntcAzAudModel.RtSpdifHDMITopo

AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RtSpdifRCAWave%, IntcAzAudModel.RtSpdifRCAWave
AddInterface=%KSCATEGORY_RENDER%,%KSNAME_RtSpdifRCAWave%, IntcAzAudModel.RtSpdifRCAWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RtSpdifRCATopo%, IntcAzAudModel.RtSpdifRCATopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_RtSpdifRCATopo%, IntcAzAudModel.RtSpdifRCATopo

AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RtSpdifOptWave%, IntcAzAudModel.RtSpdifOptWave
AddInterface=%KSCATEGORY_RENDER%,%KSNAME_RtSpdifOptWave%, IntcAzAudModel.RtSpdifOptWave
AddInterface=%KSCATEGORY_AUDIO%,%KSNAME_RtSpdifOptTopo%, IntcAzAudModel.RtSpdifOptTopo
AddInterface=%KSCATEGORY_TOPOLOGY%,%KSNAME_RtSpdifOptTopo%, IntcAzAudModel.RtSpdifOptTopo

[SourceDisksNames]
222="Realtek HD Audio Installation Disk",,,

[SourceDisksFiles]
RTKHDA64.SYS=222
RTHDCPL.EXE=222
MicCal.exe=222
CPLUTL64.EXE=222
SOUNDMAN.EXE=222
RTLCPL.EXE=222
ALCWZRD.EXE=222
ALCMTR.EXE=222
ALSNDMGR.CPL=222
RTSndMgr.CPL=222
RtlCPAPI.dll=222
RTCOMDLL.dll=222
RtlUpd64.exe=222
Skytel.exe=222
Monft64.sys=222
Ambft64.sys=222
RtkCoLDR64XP.dll=222
RCoInstII64XP.dll=222
RtkAudioService64.exe=222
vncutil64.exe=222
RTAIODAT.DAT=222

[DestinationDirs]
DefaultDestDir=10; dirid = \system32\drivers
IntcAzAudModelCopyFiles = 10,system32\drivers
RTKHD_SMAPP.CopyList=10      ;; WINDOWS
RTKHD_CPL.CopyList=10, SysWOW64        ;; WINDOWS system directory WIN98/ME->Windows\system, 2K/XP->Windows\system32
ALCAUD_SMAPP.CopyList=10      ;; WINDOWS
ALCAUD_CPL.CopyList=10, SysWOW64        ;; WINDOWS system directory WIN98/ME->Windows\system, 2K/XP->Windows\system32
AlcWzrd.CopyList   = 10             ;; WINDOWS
Alcmtr.CopyList    = 10             ;; WINDOWS
RTLCPAPI.CopyList  = 10, SysWOW64\RTCOM
RTCOMDLL.CopyList  = 10, SysWOW64\RTCOM
RTCOMDLL.DelList   = 10, SysWOW64
RTLCPAPI.DelList   = 10, SysWOW64
RTUninstall.CopyList = 10           ;; WINDOWS
FilterSys.CopyFiles =10,system32\drivers
RtkCoInst.CopyList = 11

[Strings]
MfgName="Realtek"
; not sure if this is localizable
MediaCategories="SYSTEM\CurrentControlSet\Control\MediaCategories"
; localizable
OrganizationName="Realtek Semiconductor Corp."
PackageDisplayName="HD Audio Driver"
DriverVersion="5.10.0.6631"

Audio3D_CLSID="{D8F1EEE0-F634-11CF-8700-00A0245D918B}"
AUTORUN="Software\Microsoft\Windows\CurrentVersion\Run"
RT_UNINSTALL="Software\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall\{F132AF7F-7BCA-4EDE-8A7C-958108FE7DBC}"

CPL_CLASS_S="SOFTWARE\Microsoft\Windows\CurrentVersion\Control Panel\Extended Properties\{305CA226-D286-468e-B848-2B2E8E697B74} 2"
NEWCPL_CLASS_KS="%SystemRoot%\SysWOW64\RTSndMgr.CPL"
CPL_CLASS_KS="%SystemRoot%\SysWOW64\ALSNDMGR.CPL"

RearLineOutWaveDeviceName="Realtek HD Audio rear output"
RearLineOutTopoDeviceName="Realtek HD rear output mixer"
RearLineOutDacName="HD Line Out DAC(s) for rear panel"

RearLineInWaveDeviceName="Realtek HD Audio rear input"
RearLineInTopoDeviceName="Realtek HD rear input mixer"

SecondaryLineInWaveDeviceName="Realtek HD Audio 2nd input"
SecondaryLineInTopoDeviceName="Realtek HD rear 2nd mixer"

PrimaryLineInWaveDeviceName="Realtek HDA Primary input"
PrimaryLineInTopoDeviceName="Realtek HD rear Primary mixer"

PrimaryLineOutWaveDeviceName="Realtek HDA Primary output"
PrimaryLineOutTopoDeviceName="Realtek HD Primary output mixer"

DigitalMICWaveDeviceName="Realtek Digital Microphone"
DigitalMICTopoDeviceName="Realtek Digital Microphone mixer"

SingleLineOutWaveDeviceName="Realtek HD Audio output"
SingleLineOutTopoDeviceName="Realtek HD output mixer"

FrontSpeakerWaveDeviceName="Front Speaker"
FrontSpeakeTopoDeviceName="Front Speaker mixer"

SingleLineInWaveDeviceName="Realtek HD Audio Input"
SingleLineInTopoDeviceName="Realtek HD input mixer"

SecondaryLineOutWaveDeviceName="Realtek HD Audio 2nd output"
SecondaryLineOutTopoDeviceName="Realtek HD Secondary output mixer"

RearSpeakerWaveDeviceName="Rear Speaker"
RearSpeakerTopoDeviceName="Rear Speaker mixer"

HPRearCaptureWaveDeviceName="Back Line in/Mic, Front Line in"
HPRearCaptureTopoDeviceName="Rear input, Front Line in mixer"

HPRearCaptureWaveDeviceName_XFLineIn="Back Line in/Mic"
HPRearCaptureTopoDeviceName_XFLineIn="Rear input"

HPCPCCaptureWaveDeviceName="Line in/Mic in"
HPCPCCaptureTopoDeviceName="Line in/Mic in Mixer"

RearMicInWaveDeviceName="Realtek HD rear Mic in"
RearMicInTopoDeviceName="Realtek HD rear Mic in Mixer"

FrontPanelHeadphoneWaveDeviceName="Realtek HD Audio front output"
FrontPanelHeadphoneTopoDeviceName="Realtek HD front output mixer"
FrontHPOutDacName="HD Headphone DAC for front panel" 

FrontPanelMicWaveDeviceName="Realtek HD Audio front input"
FrontPanelMicTopoDeviceName="Realtek HD Audio front input mixer"

DigitalOutputWaveDeviceName="Realtek HD Digital output"
DigitalOutputTopoDeviceName="Realtek HD Digital output mixer"

DigitalInputWaveDeviceName="Realtek HD Digital input"
DigitalInputTopoDeviceName="Realtek HD Digital input mixer"

IntcAzAudioDeviceDescription = "Realtek High Definition Audio"

AecArrayMicInWaveDeviceName="Realtek HD Audio(Array Mic)"
AecArrayMicInTopoDeviceName="Realtek HD Mixer(Array Mic)"

FrontMic2UAJWaveDeviceName="Realtek HD Front Pink Jack"
FrontMic2UAJTopoDeviceName="Realtek HD Front Pink Mixer"

FrontLine2UAJWaveDeviceName="Realtek HD Front Green Jack"
FrontLIne2UAJTopoDeviceName="Realtek HD Front Green Mixer"

RearFrontOutWaveDeviceName="Realtek HD rear/front output"
RearFrontOutTopoDeviceName="Realtek HD rear/front output mixer"

RearFrontInWaveDeviceName="Realtek HD Analog input"
RearFrontInTopoDeviceName="Realtek HD Analog input mixer"
;================================NewFrameWork===========================================
RearLineInBlackWaveDeviceName="Line in at rear panel (black)"
RearLineInBlackTopoDeviceName="Line in at rear mixer (black)"
RearLineInGreyWaveDeviceName="Line in at rear panel (Grey)"
RearLineInGreyTopoDeviceName="Line in at rear mixer (Grey)"
RearLineInBlueWaveDeviceName="Line in at rear panel (Blue)"
RearLineInBlueTopoDeviceName="Line in at rear mixer (Blue)"
RearLineInGreenWaveDeviceName="Line in at rear panel (Green)"
RearLineInGreenTopoDeviceName="Line in at rear mixer (Green)"
RearLineInRedWaveDeviceName="Line in at rear panel (Red)"
RearLineInRedTopoDeviceName="Line in at rear mixer (Red)"
RearLineInOrangeWaveDeviceName="Line in at rear panel (Orange)"
RearLineInOrangeTopoDeviceName="Line in at rear mixer (Orange)"
RearLineInYellowWaveDeviceName="Line in at rear panel (Yellow)"
RearLineInYellowTopoDeviceName="Line in at rear mixer (Yellow)"
RearLineInPurpleWaveDeviceName="Line in at rear panel (Purple)"
RearLineInPurpleTopoDeviceName="Line in at rear mixer (Purple)"
RearLineInPinkWaveDeviceName="Line in at rear panel (Pink)"
RearLineInPinkTopoDeviceName="Line in at rear mixer (Pink)"
RearLineInGoldenWaveDeviceName="Line in at rear panel (Golden)"
RearLineInGoldenTopoDeviceName="Line in at rear mixer (Golden)"
RearLineInSilverWaveDeviceName="Line in at rear panel (Silver)"
RearLineInSilverTopoDeviceName="Line in at rear mixer (Silver)"
RearLineInWhiteWaveDeviceName="Line in at rear panel (White)"
RearLineInWhiteTopoDeviceName="Line in at rear mixer (White)"
RearMicInBlackWaveDeviceName="Mic in at rear panel (black)"
RearMicInBlackTopoDeviceName="Mic in at rear mixer (black)"
RearMicInGreyWaveDeviceName="Mic in at rear panel (Grey)"
RearMicInGreyTopoDeviceName="Mic in at rear mixer (Grey)"
RearMicInBlueWaveDeviceName="Mic in at rear panel (Blue)"
RearMicInBlueTopoDeviceName="Mic in at rear mixer (Blue)"
RearMicInGreenWaveDeviceName="Mic in at rear panel (Green)"
RearMicInGreenTopoDeviceName="Mic in at rear mixer (Green)"
RearMicInRedWaveDeviceName="Mic in at rear panel (Red)"
RearMicInRedTopoDeviceName="Mic in at rear mixer (Red)"
RearMicInOrangeWaveDeviceName="Mic in at rear panel (Orange)"
RearMicInOrangeTopoDeviceName="Mic in at rear mixer (Orange)"
RearMicInYellowWaveDeviceName="Mic in at rear panel (Yellow)"
RearMicInYellowTopoDeviceName="Mic in at rear mixer (Yellow)"
RearMicInPurpleWaveDeviceName="Mic in at rear panel (Purple)"
RearMicInPurpleTopoDeviceName="Mic in at rear mixer (Purple)"
RearMicInPinkWaveDeviceName="Mic in at rear panel (Pink)"
RearMicInPinkTopoDeviceName="Mic in at rear mixer (Pink)"
RearMicInGoldenWaveDeviceName="Mic in at rear panel (Golden)"
RearMicInGoldenTopoDeviceName="Mic in at rear mixer (Golden)"
RearMicInSilverWaveDeviceName="Mic in at rear panel (Silver)"
RearMicInSilverTopoDeviceName="Mic in at rear mixer (Silver)"
RearMicInWhiteWaveDeviceName="Mic in at rear panel (White)"
RearMicInWhiteTopoDeviceName="Mic in at rear mixer (White)"
FrontLineInBlackWaveDeviceName="Line in at front panel (black)"
FrontLineInBlackTopoDeviceName="Line in at front mixer (black)"
FrontLineInGreyWaveDeviceName="Line in at front panel (Grey)"
FrontLineInGreyTopoDeviceName="Line in at front mixer (Grey)"
FrontLineInBlueWaveDeviceName="Line in at front panel (Blue)"
FrontLineInBlueTopoDeviceName="Line in at front mixer (Blue)"
FrontLineInGreenWaveDeviceName="Line in at front panel (Green)"
FrontLineInGreenTopoDeviceName="Line in at front mixer (Green)"
FrontLineInRedWaveDeviceName="Line in at front panel (Red)"
FrontLineInRedTopoDeviceName="Line in at front mixer (Red)"
FrontLineInOrangeWaveDeviceName="Line in at front panel (Orange)"
FrontLineInOrangeTopoDeviceName="Line in at front mixer (Orange)"
FrontLineInYellowWaveDeviceName="Line in at front panel (Yellow)"
FrontLineInYellowTopoDeviceName="Line in at front mixer (Yellow)"
FrontLineInPurpleWaveDeviceName="Line in at front panel (Purple)"
FrontLineInPurpleTopoDeviceName="Line in at front mixer (Purple)"
FrontLineInPinkWaveDeviceName="Line in at front panel (Pink)"
FrontLineInPinkTopoDeviceName="Line in at front mixer (Pink)"
FrontLineInGoldenWaveDeviceName="Line in at front panel (Golden)"
FrontLineInGoldenTopoDeviceName="Line in at front mixer (Golden)"
FrontLineInSilverWaveDeviceName="Line in at front panel (Silver)"
FrontLineInSilverTopoDeviceName="Line in at front mixer (Silver)"
FrontLineInWhiteWaveDeviceName="Line in at front panel (White)"
FrontLineInWhiteTopoDeviceName="Line in at front mixer (White)"
FrontMicInBlackWaveDeviceName="Mic in at front panel (black)"
FrontMicInBlackTopoDeviceName="Mic in at front mixer (black)"
FrontMicInGreyWaveDeviceName="Mic in at front panel (Grey)"
FrontMicInGreyTopoDeviceName="Mic in at front mixer (Grey)"
FrontMicInBlueWaveDeviceName="Mic in at front panel (Blue)"
FrontMicInBlueTopoDeviceName="Mic in at front mixer (Blue)"
FrontMicInGreenWaveDeviceName="Mic in at front panel (Green)"
FrontMicInGreenTopoDeviceName="Mic in at front mixer (Green)"
FrontMicInRedWaveDeviceName="Mic in at front panel (Red)"
FrontMicInRedTopoDeviceName="Mic in at front mixer (Red)"
FrontMicInOrangeWaveDeviceName="Mic in at front panel (Orange)"
FrontMicInOrangeTopoDeviceName="Mic in at front mixer (Orange)"
FrontMicInYellowWaveDeviceName="Mic in at front panel (Yellow)"
FrontMicInYellowTopoDeviceName="Mic in at front mixer (Yellow)"
FrontMicInPurpleWaveDeviceName="Mic in at front panel (Purple)"
FrontMicInPurpleTopoDeviceName="Mic in at front mixer (Purple)"
FrontMicInPinkWaveDeviceName="Mic in at front panel (Pink)"
FrontMicInPinkTopoDeviceName="Mic in at front mixer (Pink)"
FrontMicInGoldenWaveDeviceName="Mic in at front panel (Golden)"
FrontMicInGoldenTopoDeviceName="Mic in at front mixer (Golden)"
FrontMicInSilverWaveDeviceName="Mic in at front panel (Silver)"
FrontMicInSilverTopoDeviceName="Mic in at front mixer (Silver)"
FrontMicInWhiteWaveDeviceName="Mic in at front panel (White)"
FrontMicInWhiteTopoDeviceName="Mic in at front mixer (White)"
FrontMicWaveDeviceName="Front Mic"
FrontMicTopoDeviceName="Front Mic mixer"
RearMicWaveDeviceName="Rear Mic"
RearMicTopoDeviceName="Rear Mic mixer"
FjIntrMICWaveDeviceName="Internal MIC"
FjMic1WaveDeviceName="MIC In"
FjLineIn1WaveDeviceName="Line In"
RtSpdifWaveDeviceName="Realtek HDA SPDIF Out"
RtSpdifTopoDeviceName="Realtek HDA SPDIF Out Mixer"
RtSpdifHDMIWaveDeviceName="Realtek HDA HDMI Out"
RtSpdifHDMITopoDeviceName="Realtek HDA HDMI Out Mixer"
RtSpdifRCAWaveDeviceName="Realtek HDA SPDIF RCA Out"
RtSpdifRCATopoDeviceName="Realtek HDA SPDIF RCA Out Mixer"
RtSpdifOptWaveDeviceName="Realtek HDA SPDIF Optical Out"
RtSpdifOptTopoDeviceName="Realtek HDA SPDIF Optical Out Mixer"


; non localizable

KSNAME_RearLineOutWave="RearLineOutWave"
KSNAME_RearLineInWave="RearLineInWave"
KSNAME_HPRearCaptureWave="HPRearCaptureWave"
KSNAME_HPCPCCaptureWave="HPCPCCaptureWave"
;KSNAME_RearMicWave="RearMicWave"
KSNAME_FrontPanelHeadphoneWave="FrontPanelHeadphoneWave"
KSNAME_FrontPanelMicWave="FrontPanelMicWave"
KSNAME_DigitalOutputWave="DigitalOutputWave"
KSNAME_DigitalInputWave="DigitalInputWave"
KSNAME_AecArrayMicInWave="AecArrayMicInWave"
KSNAME_FrontMic2UAJWave="FrontMic2UAJWave"
KSNAME_FrontLine2UAJWave="FrontLine2UAJWave"
KSNAME_RearFrontOutWave="RearFrontOutWave"
KSNAME_RearFrontInWave="RearFrontInWave"

KSNAME_RearLineOutTopo="RearLineOutTopo"
KSNAME_RearLineInTopo="RearLineInTopo"
KSNAME_HPRearCaptureTopo="HPRearCaptureTopo"
KSNAME_HPCPCCaptureTopo="HPCPCCaptureTopo"
;KSNAME_RearMicTopo="RearMicTopo"
KSNAME_FrontPanelHeadphoneTopo="FrontPanelHeadphoneTopo"
KSNAME_FrontPanelMicTopo="FrontPanelMicTopo"
KSNAME_DigitalOutputTopo="DigitalOutputTopo"
KSNAME_DigitalInputTopo="DigitalInputTopo"
KSNAME_AecArrayMicInTopo="AecArrayMicInTopo"
KSNAME_FrontMic2UAJTopo="FrontMic2UAJTopo"
KSNAME_FrontLine2UAJTopo="FrontLine2UAJTopo"
KSNAME_RearFrontOutTopo="RearFrontOutTopo"
KSNAME_RearFrontInTopo="RearFrontInTopo"

KSNAME_HPRearCaptureWave_XFLineIn="HPRearCaptureWave_XFLineIn"
KSNAME_HPRearCaptureTopo_XFLineIn="HPRearCaptureTopo_XFLineIn"
;===============new framework================================
KSNAME_DigitalMICWave="DigitalMICWave"
KSNAME_DigitalMICTopo="DigitalMICTopo"
KSNAME_PrimaryLineOutWave="RearLineOutWave2"
KSNAME_PrimaryLineOutTopo="PrimaryLineOutTopo"
KSNAME_SingleLineOutWave="RearLineOutWave3"
KSNAME_SingleLineOutTopo="SingleLineOutTopo"
KSNAME_FrontSpeakerWave="FrontSpeakerWave"
KSNAME_FrontSpeakeTopo="FrontSpeakerTopo"
KSNAME_SingleLineInWave="RearLineInWave3"
KSNAME_SingleLineInTopo="SingleLineInTopo"
KSNAME_SecondaryLineOutWave="SecondaryLineOutWave"
KSNAME_SecondaryLineOutTopo="SecondaryLineOutTopo"
KSNAME_RearSpeakerWave="RearSpeakerWave"
KSNAME_RearSpeakerTopo="RearSpeakerTopo"
KSNAME_RearLineInBlackWave="RearLineInBlackWave"
KSNAME_RearLineInBlackTopo="RearLineInBlackTopo"
KSNAME_RearLineInGreyWave="RearLineInGreyWave"
KSNAME_RearLineInGreyTopo="RearLineInGreyTopo"
KSNAME_RearLineInBlueWave="RearLineInBlueWave"
KSNAME_RearLineInBlueTopo="RearLineInBlueTopo"
KSNAME_RearLineInGreenWave="RearLineInGreenWave"
KSNAME_RearLineInGreenTopo="RearLineInGreenTopo"
KSNAME_RearLineInRedWave="RearLineInRedWave"
KSNAME_RearLineInRedTopo="RearLineInRedTopo"
KSNAME_RearLineInOrangeWave="RearLineInOrangeWave"
KSNAME_RearLineInOrangeTopo="RearLineInOrangeTopo"
KSNAME_RearLineInYellowWave="RearLineInYellowWave"
KSNAME_RearLineInYellowTopo="RearLineInYellowTopo"
KSNAME_RearLineInPurpleWave="RearLineInPurpleWave"
KSNAME_RearLineInPurpleTopo="RearLineInPurpleTopo"
KSNAME_RearLineInPinkWave="RearLineInPinkWave"
KSNAME_RearLineInPinkTopo="RearLineInPinkTopo"
KSNAME_RearLineInGoldenWave="RearLineInGoldenWave"
KSNAME_RearLineInGoldenTopo="RearLineInGoldenTopo"
KSNAME_RearLineInSilverWave="RearLineInSilverWave"
KSNAME_RearLineInSilverTopo="RearLineInSilverTopo"
KSNAME_RearLineInWhiteWave="RearLineInWhiteWave"
KSNAME_RearLineInWhiteTopo="RearLineInWhiteTopo"
KSNAME_RearMicInBlackWave="RearMicInBlackWave"
KSNAME_RearMicInBlackTopo="RearMicInBlackTopo"
KSNAME_RearMicInGreyWave="RearMicInGreyWave"
KSNAME_RearMicInGreyTopo="RearMicInGreyTopo"
KSNAME_RearMicInBlueWave="RearMicInBlueWave"
KSNAME_RearMicInBlueTopo="RearMicInBlueTopo"
KSNAME_RearMicInGreenWave="RearMicInGreenWave"
KSNAME_RearMicInGreenTopo="RearMicInGreenTopo"
KSNAME_RearMicInRedWave="RearMicInRedWave"
KSNAME_RearMicInRedTopo="RearMicInRedTopo"
KSNAME_RearMicInOrangeWave="RearMicInOrangeWave"
KSNAME_RearMicInOrangeTopo="RearMicInOrangeTopo"
KSNAME_RearMicInYellowWave="RearMicInYellowWave"
KSNAME_RearMicInYellowTopo="RearMicInYellowTopo"
KSNAME_RearMicInPurpleWave="RearMicInPurpleWave"
KSNAME_RearMicInPurpleTopo="RearMicInPurpleTopo"
KSNAME_RearMicInPinkWave="RearMicInPinkWave"
KSNAME_RearMicInPinkTopo="RearMicInPinkTopo"
KSNAME_RearMicInGoldenWave="RearMicInGoldenWave"
KSNAME_RearMicInGoldenTopo="RearMicInGoldenTopo"
KSNAME_RearMicInSilverWave="RearMicInSilverWave"
KSNAME_RearMicInSilverTopo="RearMicInSilverTopo"
KSNAME_RearMicInWhiteWave="RearMicInWhiteWave"
KSNAME_RearMicInWhiteTopo="RearMicInWhiteTopo"
KSNAME_FrontLineInBlackWave="FrontLineInBlackWave"
KSNAME_FrontLineInBlackTopo="FrontLineInBlackTopo"
KSNAME_FrontLineInGreyWave="FrontLineInGreyWave"
KSNAME_FrontLineInGreyTopo="FrontLineInGreyTopo"
KSNAME_FrontLineInBlueWave="FrontLineInBlueWave"
KSNAME_FrontLineInBlueTopo="FrontLineInBlueTopo"
KSNAME_FrontLineInGreenWave="FrontLineInGreenWave"
KSNAME_FrontLineInGreenTopo="FrontLineInGreenTopo"
KSNAME_FrontLineInRedWave="FrontLineInRedWave"
KSNAME_FrontLineInRedTopo="FrontLineInRedTopo"
KSNAME_FrontLineInOrangeWave="FrontLineInOrangeWave"
KSNAME_FrontLineInOrangeTopo="FrontLineInOrangeTopo"
KSNAME_FrontLineInYellowWave="FrontLineInYellowWave"
KSNAME_FrontLineInYellowTopo="FrontLineInYellowTopo"
KSNAME_FrontLineInPurpleWave="FrontLineInPurpleWave"
KSNAME_FrontLineInPurpleTopo="FrontLineInPurpleTopo"
KSNAME_FrontLineInPinkWave="FrontLineInPinkWave"
KSNAME_FrontLineInPinkTopo="FrontLineInPinkTopo"
KSNAME_FrontLineInGoldenWave="FrontLineInGoldenWave"
KSNAME_FrontLineInGoldenTopo="FrontLineInGoldenTopo"
KSNAME_FrontLineInSilverWave="FrontLineInSilverWave"
KSNAME_FrontLineInSilverTopo="FrontLineInSilverTopo"
KSNAME_FrontLineInWhiteWave="FrontLineInWhiteWave"
KSNAME_FrontLineInWhiteTopo="FrontLineInWhiteTopo"
KSNAME_FrontMicInBlackWave="FrontMicInBlackWave"
KSNAME_FrontMicInBlackTopo="FrontMicInBlackTopo"
KSNAME_FrontMicInGreyWave="FrontMicInGreyWave"
KSNAME_FrontMicInGreyTopo="FrontMicInGreyTopo"
KSNAME_FrontMicInBlueWave="FrontMicInBlueWave"
KSNAME_FrontMicInBlueTopo="FrontMicInBlueTopo"
KSNAME_FrontMicInGreenWave="FrontMicInGreenWave"
KSNAME_FrontMicInGreenTopo="FrontMicInGreenTopo"
KSNAME_FrontMicInRedWave="FrontMicInRedWave"
KSNAME_FrontMicInRedTopo="FrontMicInRedTopo"
KSNAME_FrontMicInOrangeWave="FrontMicInOrangeWave"
KSNAME_FrontMicInOrangeTopo="FrontMicInOrangeTopo"
KSNAME_FrontMicInYellowWave="FrontMicInYellowWave"
KSNAME_FrontMicInYellowTopo="FrontMicInYellowTopo"
KSNAME_FrontMicInPurpleWave="FrontMicInPurpleWave"
KSNAME_FrontMicInPurpleTopo="FrontMicInPurpleTopo"
KSNAME_FrontMicInPinkWave="FrontMicInPinkWave"
KSNAME_FrontMicInPinkTopo="FrontMicInPinkTopo"
KSNAME_FrontMicInGoldenWave="FrontMicInGoldenWave"
KSNAME_FrontMicInGoldenTopo="FrontMicInGoldenTopo"
KSNAME_FrontMicInSilverWave="FrontMicInSilverWave"
KSNAME_FrontMicInSilverTopo="FrontMicInSilverTopo"
KSNAME_FrontMicInWhiteWave="FrontMicInWhiteWave"
KSNAME_FrontMicInWhiteTopo="FrontMicInWhiteTopo"
KSNAME_PrimaryLineInWave="PrimaryLineInWave"
KSNAME_PrimaryLineInTopo="PrimaryLineInTopo"
KSNAME_FrontMicWave="FrontMicWave"
KSNAME_FrontMicTopo="FrontMicTopo"
KSNAME_RearMicWave="RearMicWave"
KSNAME_RearMicTopo="RearMicTopo"
KSNAME_SecondaryLineInWave="SecondaryLineInWave"
KSNAME_SecondaryLineInTopo="SecondaryLineInTopo"
KSNAME_FjIntrMICWave="FjIntrMICWave"
KSNAME_FjMic1Wave="FjMic1Wave"
KSNAME_FjLineIn1Wave="FjLineIn1Wave"
KSNAME_RtSpdifWave="RtSpdifWave"
KSNAME_RtSpdifTopo="RtSpdifTopo"
KSNAME_RtSpdifHDMIWave="RtSpdifHDMIWave"
KSNAME_RtSpdifHDMITopo="RtSpdifHDMITopo"
KSNAME_RtSpdifRCAWave="RtSpdifRCAWave"
KSNAME_RtSpdifRCATopo="RtSpdifRCATopo"
KSNAME_RtSpdifOptWave="RtSpdifOptWave"
KSNAME_RtSpdifOptTopo="RtSpdifOptTopo"

;=================Skype======================
KSNAME_SkypeLineInWave="SkypeLineInWave"
KSNAME_SKypeLineInTopo="SkypeLineInTopo"
KSNAME_SkypeLineOutWave="SkypeLineOutWave"
KSNAME_SKypeLineOutTopo="SkypeLineOutTopo"
KSNAME_SkypeVoiceWave="SkypeVoiceWave"
KSNAME_SKypeVoiceTopo="SkypeVoiceTopo"
KSNAME_SkypeVoiceInWave="SkypeVoiceInWave"
KSNAME_SkypeVoiceInTopo="SkypeVoiceInTopo"


SkypeLineInWaveDeviceName="Realtek HD Audio Skype Input"
SkypeLineInTopoDeviceName="Realtek HD Skype  Input mixer"
SkypeLineOutWaveDeviceName="Realtek HD Audio Skype Output"
SkypeLineOutTopoDeviceName="Realtek HD Skype  Ontput mixer"
SkypeVoiceWaveDeviceName="Realtek Voice Out"
SkypeVoiceTopoDeviceName="Realtek Voice Out mixer"
SkypeVoiceInWaveDeviceName="Realtek Voice In"
SkypeVoiceInTopoDeviceName="Realtek Voice In mixer"



KSCATEGORY_AUDIO = "{6994AD04-93EF-11D0-A3CC-00A0C9223196}"
KSCATEGORY_RENDER="{65E8773E-8F56-11D0-A3B9-00A0C9223196}"
KSCATEGORY_CAPTURE="{65E8773D-8F56-11D0-A3B9-00A0C9223196}"
KSCATEGORY_TOPOLOGY="{DDA54A40-1E4C-11D1-A050-405705C10000}"
Proxy.CLSID ="{17CCA71B-ECD7-11D0-B908-00A0C9223196}"

RTLCPAPI_CLSID="{E9F1F599-7B14-4213-BF46-F992758CAB81}"

RTCOMDLL_CLSID="{CC0CA09A-5B84-43F2-BE5C-9169C192565F}"
RTCOMDLL_CLSID2="{A9C2CEBF-36DC-40A3-92E6-ED59FDD9D20D}"
RTCOMDLL_CLSID3="{C6606CA5-2108-4CAF-8E52-1953F2DBF716}"
RTCOMDLL_CLSID4="{E0760680-E3E3-41A6-A5BE-275F5C21BDD9}"
RTCOMDLL_CLSID5="{5B05A596-33CA-4D65-B6C8-42704CA9BE2A}"

; guids for rear line out
IntAzAudGuidRearLineOutDac= "{EEF86A90-3742-4974-B8D2-5370E1C540F6}"
IntAzAudGuidFrontHPOutDac = "{497B34AD-D67F-411c-8076-80D5B4250D67}"

;; Node
GUID.FrontMicVolume     ="{8E1FC059-D41D-417f-8103-FC592A4B32C8}"
GUID.FrontMicMute       ="{65D86BEA-A16C-4e40-9F01-50C559D721B9}"
GUID.UAJ1               ="{E7CD3EA7-072F-4d9f-B94A-744108964E0E}"
GUID.UAJ2               ="{93FCBD9E-08CD-4cbd-B018-5EE0B83E7AF0}"
GUID.SPDIF              ="{7B1A60BA-4F2D-41f6-95B1-5589F90D1ECE}"
GUID.FrontLin           ="{757AB5CF-F4D5-42e4-9609-BF78FC6C712B}"
GUID.Front              ="{8A74FFAE-8766-480f-AF6D-325FCF9AB324}"
GUID.Surround           ="{B25A6526-9703-4117-9D7F-260A5DF5CC34}"
GUID.Center             ="{594AC582-B82A-4024-99E7-DC5B358E0F30}"
GUID.LFE                ="{19532773-C332-4de7-BEDD-F888163C3094}"
GUID.Side               ="{A5B27DE2-40F3-469e-9A4D-2CD8D5D9284D}"
GUID.DigitalOut         ="{7CB80EC0-9C2D-4924-AA30-3DB3864F8CD6}"
GUID.DigitalIn          ="{4F30E318-2B36-4b46-AF17-36A336363A12}"
GUID.LineInHP           ="{B001EDFD-CF09-402f-8652-2E32AE568508}"
GUID.Mic2               ="{2216D589-3C9F-4843-B4E9-933F2ABCA6D2}"
GUID.FrontPinkInOld        ="{39E595A1-9F2B-4276-A416-8D7A1534F01C}"
GUID.FrontGreenInOld       ="{38CB5F75-F95A-425c-8444-F1C18942DB14}"
GUID.AudioIn            ="{D4649B85-6687-4ec4-8C65-5B7B6248C470}"
GUID.LineOutVolume      ="{9ACC8A34-DBF9-416d-97E7-3B90FE28FBD1}"
GUID.PcBeepVolume       ="{093C0065-6B45-4582-87D7-5A6742F6E859}"
GUID.Surr               ="{38D6C869-D317-4dd2-B1B0-A9CAD8DD9639}"
GUID.Surrback           ="{C6E24B42-19BF-4211-9021-C696E3284C4F}"
GUID.MonoMic            ="{3BEFF10F-1EC8-448f-9654-73067CCE3C6A}"
GUID.StereoMic          ="{AA23B58F-B6D2-4952-B318-A0304B7EDEB3}"
GUID.PCBeep             ="{C57704A3-108F-4760-99BA-6369AD13345D}"
GUID.SideHP             ="{C61C32C2-2BE7-467e-A278-B49E6746921E}"
GUID.MicLineInVolume     ="{5B08FA7D-A8BC-42a6-A1A9-C52AB5FC47A7}"

;; Nodes (localizeable)
Node.FrontMicVolume     ="Front Mic"
Node.FrontMicMute       ="FrontMic Mute"
Node.UAJ1               ="FPink"
Node.UAJ2               ="FGreen"
Node.SPDIF              ="SPDIF"
Node.FrontLin           ="FrontLineIn"
Node.Front              ="Front"
Node.Surround           ="Rear"
Node.Center             ="Center"
Node.LFE                ="Subwoofer"
Node.Side               ="Side"
Node.DigitalOut         ="DigitalOut"
Node.DigitalIn          ="DigitalIn"
Node.LineInHP           ="Line In 1 or 2"
Node.Mic2               ="Microphone2"
Node.FrontPinkInOld        ="FrontPink In"
Node.FrontGreenInOld       ="FrontGreen In"
Node.AudioIn            ="Audio In"
Node.LineOutVolume      = "Line Out"
Node.Surr               ="Surround"
Node.Surrback           ="Surr-Back"
Node.MonoMic            ="Mono Mic"
Node.StereoMic          ="Stereo Mic"
Node.PCBeep             ="PC Beep"
Node.PcBeepVolume       ="PC Beep"
Node.SideHP             ="Side/HP"
Node.MicLineInVolume     ="Mic/Line In"
;;New Framework
GUID.FrontMicIn              ="{6850DF22-3CA7-4e09-B5AE-0DE820BF8356}"
Node.FrontMicIn              ="Front Mic-In"
GUID.FrontHPIn               ="{46474F89-723B-4cac-9FD7-679FB5EE8F69}"
Node.FrontHPIn               ="Front HP-In"
GUID.DigitalMic              ="{7DF69A32-C356-4f5a-A3BB-757B8B5177D4}"
Node.DigitalMic              ="Digital Mic"
GUID.FrontBlackIn            ="{C1857CBB-5FEA-420c-89FD-0479D7D366FB}"
Node.FrontBlackIn            ="Front Black In"
GUID.FrontGreyIn             ="{74B67688-4723-4ec7-A1A6-09F33FF91FDB}"
Node.FrontGreyIn             ="Front Grey In"
GUID.FrontBlueIn             ="{9B0DC1D3-EFC8-4364-8ACD-9172D388F487}"
Node.FrontBlueIn             ="Front Blue In"
GUID.FrontGreenIn            ="{BA697E2A-BC14-4c0d-9E16-3935F2F15E08}"
Node.FrontGreenIn            ="Front Green In"
GUID.FrontRedIn              ="{AC846E6F-5695-4cec-B694-956A2E689AF4}"
Node.FrontRedIn              ="Front Red In"
GUID.FrontOrangeIn           ="{C2BEEC11-5DF2-4fd9-B2D1-B5E2A1E46CB7}"
Node.FrontOrangeIn           ="Front Orange In"
GUID.FrontYellowIn           ="{783FFBEB-79D4-40b8-BBB4-B90479D17F1F}"
Node.FrontYellowIn           ="Front Yellow In"
GUID.FrontPurpleIn           ="{0D95D21C-2FF7-4a66-9526-CC39DA3E749E}"
Node.FrontPurpleIn           ="Front Purple In"
GUID.FrontPinkIn             ="{930A479F-0487-4baa-9672-4C7C36C0EFB2}"
Node.FrontPinkIn             ="Front Pink In"
GUID.FrontGoldenIn           ="{8FED8EA0-0485-408c-9963-D3AC59D34A1F}"
Node.FrontGoldenIn           ="Front Golden In"
GUID.FrontSilverIn           ="{FB0CBA7B-73ED-4880-9A7F-338D67AB1E71}"
Node.FrontSilverIn           ="Front Silver In"
GUID.FrontWhiteIn            ="{788F5056-8394-4bf5-8608-B8BC009F9B0D}"
Node.FrontWhiteIn            ="Front White In"
GUID.RearBlackIn             ="{16238C4C-5B07-4acf-9B1D-72056187853C}"
Node.RearBlackIn             ="Rear Black In"
GUID.RearGreyIn              ="{066ED7CF-26FC-4cd6-8DB0-BDA088FFC7B6}"
Node.RearGreyIn              ="Rear Grey In"
GUID.RearBlueIn              ="{25C9B7B5-B490-4418-B8C9-AE6A9E597D10}"
Node.RearBlueIn              ="Rear Blue In"
GUID.RearGreenIn             ="{D5841A06-2012-49bb-848A-4E3C9D8E83EC}"
Node.RearGreenIn             ="Rear Green In"
GUID.RearRedIn               ="{EEB9FF66-875E-44d0-A7BC-94F8FF8A6B2E}"
Node.RearRedIn               ="Rear Red In"
GUID.RearOrangeIn            ="{656A2737-0A8D-4c24-B11B-2CF3568DF248}"
Node.RearOrangeIn            ="Rear Orange In"
GUID.RearYellowIn            ="{EA1B271B-D19A-41ea-9141-E0FE75259300}"
Node.RearYellowIn            ="Rear Yellow In"
GUID.RearPurpleIn            ="{D907F836-CE83-4354-B62C-B9700CCC0366}"
Node.RearPurpleIn            ="Rear Purple In"
GUID.RearPinkIn              ="{CECB705D-C0D9-4c47-84F6-0A210E9DFD0B}"
Node.RearPinkIn              ="Rear Pink In"
GUID.RearGoldenIn            ="{98B9900B-618A-4bd3-9B62-B206E9AA5F6F}"
Node.RearGoldenIn            ="Rear Golden In"
GUID.RearSilverIn            ="{B8CE8B6A-A73E-494d-8218-F308670F6149}"
Node.RearSilverIn            ="Rear Silver In"
GUID.RearWhiteIn             ="{6D33D369-990F-444b-A4E6-57A29B8F0993}"
Node.RearWhiteIn             ="Rear White In"
;;======================================================================
GUID.BlackIn            ="{2AFE8623-D5B6-49d6-898D-A16A616E571B}"
Node.BlackIn            ="Black In"
GUID.GreyIn             ="{8A965A50-6F78-424c-8EDD-DD904C4C7AAC}"
Node.GreyIn             ="Grey In"
GUID.BlueIn             ="{CD2AAD6D-761E-4b6d-A4C6-8F543A38C099}"
Node.BlueIn             ="Blue In"
GUID.GreenIn            ="{5153DE62-8983-4a02-8F87-2969BC2A279A}"
Node.GreenIn            ="Green In"
GUID.RedIn              ="{6735C4E4-C0DA-473f-8D1F-2FD185C83071}"
Node.RedIn              ="Red In"
GUID.OrangeIn           ="{B89B4F6B-5820-46a0-999C-A9765221DA30}"
Node.OrangeIn           ="Orange In"
GUID.YellowIn           ="{D7F95568-524C-4ef1-A58E-1E8BF3E4443E}"
Node.YellowIn           ="Yellow In"
GUID.PurpleIn           ="{A57DE92C-E432-4432-8166-E02D8C4ACDDC}"
Node.PurpleIn           ="Purple In"
GUID.PinkIn             ="{C0F074E4-0F6A-4b6f-BC09-5DF75D24757F}"
Node.PinkIn             ="Pink In"
GUID.GoldenIn           ="{72DA7D85-CCB7-4bce-BDD7-A8F0E56958B8}"
Node.GoldenIn           ="Golden In"
GUID.SilverIn           ="{892B95E3-FEA5-48b2-93B8-49373E588E38}"
Node.SilverIn           ="Silver In"
GUID.WhiteIn            ="{710CE1E3-334A-4771-A4B2-CFFF54B70DBF}"
Node.WhiteIn            ="White In"
GUID.AudioInput         ="{B8B35FC5-6051-44e0-A3CE-B6E000564C64}"
Node.AudioInput         ="Audio Input"
GUID.LineIn1            ="{1B5D1795-4D18-4057-81DA-06A5FC19F3AC}"
GUID.LineIn2            ="{AD8341CB-C580-46e7-B593-44440EFB4DE8}"
Node.LineIn1            ="Line In 1"
Node.LineIn2            ="Line In 2"
GUID.TVIn               ="{38FAF4E0-3EEF-47d7-AD52-F20AB10340C3}"
Node.TVIn               ="TV In"
GUID.FrontAVIn          ="{E27EEDDE-A24D-4f87-8EDE-5A58E7FF8D70}"
Node.FrontAVIn          ="Front AV In"
GUID.DisableAnalogCD	="{08FDB237-3D34-4c59-9511-56E178AE3E10}"
Node.DisableAnalogCD	="Disable Analog CD"
GUID.LimitedOutput	="{D172D8CE-0235-4b09-92EB-BDE320CFB94C}"
Node.LimitedOutput	="Limited Output"

GUID.RTSPDIFOut			="{8FD300D2-FFE1-44f3-A9EB-6F4395D73C9F}"
Node.RTSPDIFOut			="Realtek Digital Output"
GUID.RTHDMI			="{DCF74E0A-8B16-40aa-8A51-A4B89EF9B7B6}"
Node.RTHDMI			="HDMI"
GUID.RTHDMIOut			="{9C8E490E-877D-48fe-9EF1-AD83C91CC057}"
Node.RTHDMIOut			="Realtek HDMI Output"
GUID.RTSPDIFOutRCA		="{3FF4EDB6-3FF3-4b5a-B164-10FFF0367547}"
Node.RTSPDIFOutRCA		="Realtek Digital Output(RCA)"
GUID.RTSPDIFOutOpt		="{94FCA009-B26E-4cdc-AC75-051613EF01BB}"
Node.RTSPDIFOutOpt		="Realtek Digital Output(Optical)"

GUID.RTSPDIFIn			="{8FD300D3-FFE1-44f3-A9EB-6F4395D73C9F}"
Node.RTSPDIFIn			="Realtek Digital Input"

GUID.RearLineOutWave3   ="{FDCD16F9-7895-4f2c-9E95-2C4F62DE500D}"
GUID.FrontSpeakerWave   ="{6172E12A-D04D-4d29-AAA9-39387F5511A7}"
GUID.RearLineOutWave2   ="{73EC718D-EEBD-4305-BD56-E50807C4B3E2}"
GUID.SecondaryLineOutWave ="{D0D252D2-0D9A-47f7-B44B-3FB73C31F6FA}"
GUID.RearSpeakerWave ="{F4BF56C8-BE06-41dc-B8B5-00E225D814E6}"

GUID.RearLineInBlackWave  ="{29FAD4B6-42C6-46fe-85D2-772B3F38E42B}"
GUID.RearLineInGreyWave   ="{5D3113BA-46E3-4e48-BF97-5E1486E5C845}"
GUID.RearLineInBlueWave   ="{6EDFC84F-270B-43f4-A4DA-F4FA32BE0023}"
GUID.RearLineInGreenWave  ="{4C28B434-D501-4131-A626-D667F954A279}"
GUID.RearLineInRedWave    ="{F9C764D1-0A97-4216-BD80-57D11C86BF21}"
GUID.RearLineInOrangeWave ="{FA3C462A-11E7-4cfe-9C20-4208E87EE2F1}"
GUID.RearLineInYellowWave ="{242792D9-E16F-4e09-9F4A-FD5C910230F2}"
GUID.RearLineInPurpleWave ="{64593A8D-8942-415f-83F7-495232599984}"
GUID.RearLineInPinkWave   ="{3FAF44E8-FC47-4921-AA2A-CB511CD5A340}"
GUID.RearLineInGoldenWave ="{A18CE952-B042-42d4-AE98-6AD616604407}"
GUID.RearLineInSilverWave ="{9ABF55D5-4319-4e1e-A1E6-D720FB153A73}"
GUID.RearLineInWhiteWave  ="{39514CCF-B424-454d-A2DD-7CCCC41902CC}"

GUID.RearMicInBlackWave   ="{963BB9C2-C99A-4278-8C85-0A53FAD66593}"
GUID.RearMicInGreyWave    ="{750D77D8-DD18-45fa-813B-31AAF37D8816}"
GUID.RearMicInBlueWave    ="{D09B4160-D155-4409-814C-7BDFD3DCC115}"
GUID.RearMicInGreenWave   ="{E63A12AB-7A2A-40bf-B5F5-176F3E17A75B}"
GUID.RearMicInRedWave     ="{397BCD99-443F-4f0a-91F7-8CF33B73E7B5}"
GUID.RearMicInOrangeWave  ="{DF15C716-2E97-498c-953B-71B1A6E4BD03}"
GUID.RearMicInYellowWave  ="{A80B8021-3A94-4cba-A31F-A30285215AEB}"
GUID.RearMicInPurpleWave  ="{ADA7C584-EC2C-4bad-9491-38EA3EDC364E}"
GUID.RearMicInPinkWave    ="{9767F352-1066-4606-B843-EB3DFF14AE48}"
GUID.RearMicInGoldenWave  ="{0BF09DFA-1DC9-45d6-9E68-B62FCE22F574}"
GUID.RearMicInSilverWave  ="{D88BF175-E66E-41f6-91A0-1AE5BD7FB550}"
GUID.RearMicInWhiteWave   ="{C949BDB2-0F63-411d-9A1C-FF2C68137986}"

GUID.FrontLineInBlackWave ="{E922348B-F538-48f2-8A46-03610CA3C815}"
GUID.FrontLineInGreyWave  ="{F84AD65F-8888-4076-BA55-15FA42C66D43}"
GUID.FrontLineInBlueWave  ="{EEA8F0C2-15F2-47ba-9939-8B68B99B5A47}"
GUID.FrontLineInGreenWave ="{D9CFB32D-C42A-446d-8D3D-BE3ACF1FE392}"
GUID.FrontLineInRedWave   ="{37E6001D-7297-439e-BB83-EAAA48F54DE1}"
GUID.FrontLineInOrangeWave="{0FBC7B0C-368C-468a-ADCA-A9C1DFD67B01}"
GUID.FrontLineInYellowWave="{C1601920-82B6-411d-B1EB-F1B8A9DD2DCD}"
GUID.FrontLineInPurpleWave="{F32BA73A-930B-4596-A47F-A9339FB7E24C}"
GUID.FrontLineInPinkWave  ="{9EC96236-A9B3-45b3-8E19-C4F424399457}"
GUID.FrontLineInGoldenWave="{9F31B40E-E3D2-4683-8CD8-DD29972CBD6A}"
GUID.FrontLineInSilverWave="{9B706B3E-F3FE-4d4b-B410-468D3E083D98}"
GUID.FrontLineInWhiteWave ="{6E56DB59-D4D1-4fa8-9575-AE39763E14C7}"

GUID.FrontMicInBlackWave  ="{063C7B0E-7D63-45ea-BD17-BD2383C9DA48}"
GUID.FrontMicInGreyWave   ="{F6810363-D355-4c27-B60C-DB10B4A6DB1F}"
GUID.FrontMicInBlueWave   ="{4872BA3F-61F9-495f-97C1-0FC6D149B0D8}"
GUID.FrontMicInGreenWave  ="{564C8501-3C26-4051-B3DF-80157C565158}"
GUID.FrontMicInRedWave    ="{FA5703D8-BC38-4759-BDDB-53A0A9977D86}"
GUID.FrontMicInOrangeWave ="{2F055121-7B49-4389-AE10-6D8FDB6F9E15}"
GUID.FrontMicInYellowWave ="{67DC169B-1C82-4fb7-B566-CC917F303CD7}"
GUID.FrontMicInPurpleWave ="{8DE7D024-880C-4a50-BFBA-6118FA703728}"
GUID.FrontMicInPinkWave   ="{D3D9A153-5556-40a7-8C1B-E476344A524A}"
GUID.FrontMicInGoldenWave ="{4F8E73AF-13D0-4ab4-BD05-DA13475B6D99}"
GUID.FrontMicInSilverWave ="{9B72B3D3-32F5-4d3b-868E-C506824ED45A}"
GUID.FrontMicInWhiteWave  ="{53824709-A7CA-4432-9423-D47A01938B83}"
GUID.FrontMicWave 	  ="{0B0979FF-2700-45a9-AA36-469405A2BB8F}"
GUID.RearMicWave 	  ="{5FF88597-5ADD-49d6-8095-29364CD5E0F6}"

GUID.FMRadio              ="{93ED2CB4-7D0D-4c1c-8A91-5AE457E066AD}"
Node.FMRadio              ="FM radio"

GUID.FjIntrMICWave        ="{703EFE0E-C7D3-4506-96BF-E2D28E2ECEEE}"
GUID.FjMic1Wave           ="{703EFE0D-C7D3-4506-96BF-E2D28E2ECEEE}"
GUID.FjLineIn1Wave        ="{703EFE0C-C7D3-4506-96BF-E2D28E2ECEEE}"
GUID.IntrSubWoofer        ="{CE407554-302B-44a8-9455-BB933694A1A5}"
IntrSubWooferDeviceName="Internal Subwoofer"

                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      