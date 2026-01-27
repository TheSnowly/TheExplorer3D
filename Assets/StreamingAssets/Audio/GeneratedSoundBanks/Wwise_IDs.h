/////////////////////////////////////////////////////////////////////////////////////////////////////
//
// Audiokinetic Wwise generated include file. Do not edit.
//
/////////////////////////////////////////////////////////////////////////////////////////////////////

#ifndef __WWISE_IDS_H__
#define __WWISE_IDS_H__

#include <AK/SoundEngine/Common/AkTypes.h>

namespace AK
{
    namespace EVENTS
    {
        static const AkUniqueID MC_ATTACK = 4170654020U;
        static const AkUniqueID MC_ATTACK_END_COMBO = 1439233273U;
        static const AkUniqueID MC_DEATH = 3389321894U;
        static const AkUniqueID MC_FOLIAGE = 38756753U;
        static const AkUniqueID MC_HURT = 3631971675U;
        static const AkUniqueID MC_JUMP = 2727768564U;
        static const AkUniqueID MC_LAND = 2166447543U;
        static const AkUniqueID MC_LAND_ROLL = 358198507U;
        static const AkUniqueID MC_PRESENCE = 4218582063U;
        static const AkUniqueID MC_RESPAWN = 748388956U;
        static const AkUniqueID MC_SCUFF = 1959425923U;
        static const AkUniqueID MC_WALK = 2385440235U;
        static const AkUniqueID PLAY_FOL_ATTACKMELEEFOOTSTEPS = 2291827489U;
        static const AkUniqueID PLAY_FOL_GRENADIER_FOOTSTEPS_SOFT = 4131994226U;
        static const AkUniqueID PLAY_FOL_GRENADIER_FOOTSTEPS_WALK = 3037255001U;
        static const AkUniqueID PLAY_FOL_GRENADIER_PRESENCES_WALK = 1615984476U;
        static const AkUniqueID PLAY_GRENADIER_SHOCKWAVE = 3939029689U;
        static const AkUniqueID PLAY_GRENADIER_TAKEDAMAGE = 884913238U;
        static const AkUniqueID PLAY_SFX_ATTACKMELEECORE = 565748451U;
        static const AkUniqueID PLAY_SFX_GRENADIER_DEATH = 1318347994U;
        static const AkUniqueID PLAY_SFX_GRENADIER_IDLE_BREATH = 3336111879U;
        static const AkUniqueID PLAY_SFX_GRENADIER_IDLE_VOX = 4067060800U;
        static const AkUniqueID PLAY_SFX_GRENADIER_LIGHTBALL_LP = 3960731846U;
        static const AkUniqueID PLAY_SFX_GRENADIER_RANGEATTACK = 1596895987U;
        static const AkUniqueID PLAY_SFX_GRENADIER_RANGEATTACK_BALLBOUNCE = 3181249561U;
        static const AkUniqueID PLAY_SFX_GRENADIER_RANGEATTACK_BALLEXPLOSION = 1344656670U;
        static const AkUniqueID PLAY_SFX_TURNANIM = 3335774388U;
        static const AkUniqueID PLAY_VOX_GRENADIER = 9845879U;
        static const AkUniqueID STOP_SFX_GRENADIER_IDLE_BREATH = 854495237U;
        static const AkUniqueID STOP_SFX_GRENADIER_LIGHTBALL_LP_01 = 1361203702U;
    } // namespace EVENTS

    namespace SWITCHES
    {
        namespace FT_TYPE
        {
            static const AkUniqueID GROUP = 3861009810U;

            namespace SWITCH
            {
                static const AkUniqueID DIRT = 2195636714U;
                static const AkUniqueID GRASS = 4248645337U;
                static const AkUniqueID STONE = 1216965916U;
            } // namespace SWITCH
        } // namespace FT_TYPE

        namespace SW_SFX_TURNANIM
        {
            static const AkUniqueID GROUP = 3604664336U;

            namespace SWITCH
            {
                static const AkUniqueID SW_TURN45LEFT = 2279591401U;
                static const AkUniqueID SW_TURN45RIGHT = 1020888412U;
                static const AkUniqueID SW_TURN90LEFT = 3883533363U;
                static const AkUniqueID SW_TURN90RIGHT = 1153136558U;
                static const AkUniqueID SW_TURN135LEFT = 905754327U;
                static const AkUniqueID SW_TURN135RIGHT = 1241393402U;
                static const AkUniqueID SW_TURN180LEFT = 1758166467U;
                static const AkUniqueID SW_TURN180RIGHT = 2927824766U;
            } // namespace SWITCH
        } // namespace SW_SFX_TURNANIM

        namespace SW_VOX_GRENADIER
        {
            static const AkUniqueID GROUP = 1600642307U;

            namespace SWITCH
            {
                static const AkUniqueID SW_ATTACKMELEE = 568828562U;
                static const AkUniqueID SW_ATTACKRANGE_GRENADE = 2330164382U;
                static const AkUniqueID SW_ATTACKRANGE_SHOCKWAVE = 1769902645U;
                static const AkUniqueID SW_DEATH = 2106196784U;
                static const AkUniqueID SW_PURSUIT = 3178641716U;
                static const AkUniqueID SW_SHIELD = 2400886981U;
                static const AkUniqueID SW_TAKEDAMAGE = 3996901420U;
            } // namespace SWITCH
        } // namespace SW_VOX_GRENADIER

    } // namespace SWITCHES

    namespace BANKS
    {
        static const AkUniqueID INIT = 1355168291U;
        static const AkUniqueID GRENADIER = 1343892184U;
        static const AkUniqueID MC = 1685527061U;
    } // namespace BANKS

    namespace BUSSES
    {
        static const AkUniqueID AMB = 1117531639U;
        static const AkUniqueID ENEMIES = 2242381963U;
        static const AkUniqueID GRENADIER = 1343892184U;
        static const AkUniqueID GRENADIER_FOOTSTEPS = 2575231005U;
        static const AkUniqueID MASTER_AUDIO_BUS = 3803692087U;
        static const AkUniqueID MC = 1685527061U;
        static const AkUniqueID SFX = 393239870U;
        static const AkUniqueID UI = 1551306167U;
    } // namespace BUSSES

    namespace AUDIO_DEVICES
    {
        static const AkUniqueID NO_OUTPUT = 2317455096U;
        static const AkUniqueID SYSTEM = 3859886410U;
    } // namespace AUDIO_DEVICES

}// namespace AK

#endif // __WWISE_IDS_H__
