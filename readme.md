# USB Cash Drawer SDK for Windows - from Star Labs

SDK for SMD2 Max and CD3 Value series USB Cash Drawers.  
More info on the Cash Drawers can be found on our [website](https://www.starmicronics.com/pages/pos-cash-register-drawers).

This SDK is distributed as a DLL and a sample app is provided to demonstrate usage.  

## Star Labs
This SDK is a Star Labs project meaning that it is created and released, under an open source license, by Star Micronics employees or subsidiaries, but is not an official Star Micronics software product and not subject to the same guarantees, support or testing requirements from Star Micronics Co Ltd, Japan. As a result, quality, reliability and global support availability will vary between Star Labs projects, please check the project specific support information for details.

## Star Labs Project Status
This project has been developed by Star Micronics America and is safe to use in production.  
Direct support is provided for the following regions: USA, Canada, Latin & Central America, and the Caribbean.

## Getting Started

Run the included Visual Studio Solution or add the DLL to you own project.

## Accessing the Cash Drawer class  
`using StarLabs.CashDrawer;`

The **CashDrawer** class provides functions for:
- discovering connected Cash Drawers, up to 8 can be connected at once.
- checking open/closed state
- opening the Cash Drawer

## USB Cash Drawer PID/VID Information
The PID (Product ID) of our USB cash drawers can change based on the DIP switch settings. This feature is intentional in case users have multiple drawers and want them to be distinguishable by software.

The VID (Vendor ID) for Star Micronics USB cash drawers is 0519 (in HEX). The PID, however, can vary depending on the DIP switch settings on the back of the cash drawer, which control the USB ID.

## DIP Switch Settings for USB IDs
The following table outlines how the DIP switches should be configured to assign a specific USB ID. The default factory setting is USB ID 1011, with all switches set to 0 (OFF).

<img width="685" alt="viv_pid1" src="https://github.com/user-attachments/assets/297e6667-2d6a-4808-97d4-fdfd71f7a04a" />
