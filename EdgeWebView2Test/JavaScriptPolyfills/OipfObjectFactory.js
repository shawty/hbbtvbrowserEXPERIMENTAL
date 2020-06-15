window.oipfObjectFactory = {

  isObjectSupported: function (mimetype) {
    return window.chrome.webview.hostObjects.sync.oipfInternal.isObjectSupported(mimetype);
  },

  createVideoBroadcastObject: function () {
    return new HTMLObjectElement();
  },

  createVideoMpegObject: function () {
    return new HTMLObjectElement();
  },

  createStatusViewObject: function () {
    let err = new Error("Object type not supported by OITF.");
    err.name = "TypeError";
    throw err;
  },

  createApplicationManagerObject: function () {
    return window.hbbtvBrowser.oipfObjects.applicationManager;
  },

  createCapabilitiesObject: function () {
    return new Object();
  },

  createChannelConfig: function () {
    return window.hbbtvBrowser.oipfObjects.channelConfig;
  },

  createCodManagerObject: function () {
    let err = new Error("Object type not supported by OITF.");
    err.name = "TypeError";
    throw err;
  },

  createConfigurationObject: function () {
    return new Object();
  },

  createDownloadManagerObject: function () {
    let err = new Error("Object type not supported by OITF.");
    err.name = "TypeError";
    throw err;
  },

  createDownloadTriggerObject: function () {
    let err = new Error("Object type not supported by OITF.");
    err.name = "TypeError";
    throw err;
  },

  createDrmAgentObject: function () {
    return new Object();
  },

  createGatewayInfoObject: function () {
    let err = new Error("Object type not supported by OITF.");
    err.name = "TypeError";
    throw err;
  },

  createIMSObject: function () {
    let err = new Error("Object type not supported by OITF.");
    err.name = "TypeError";
    throw err;
  },

  createMDTFObject: function () {
    let err = new Error("Object type not supported by OITF.");
    err.name = "TypeError";
    throw err;
  },

  createNotifSocketObject: function () {
    let err = new Error("Object type not supported by OITF.");
    err.name = "TypeError";
    throw err;
  },

  createParentalControlManagerObject: function () {
    return new Object();
  },

  createRecordingSchedulerObject: function () {
    let err = new Error("Object type not supported by OITF.");
    err.name = "TypeError";
    throw err;
  },

  createRemoteControlFunctionObject: function () {
    let err = new Error("Object type not supported by OITF.");
    err.name = "TypeError";
    throw err;
  },

  createRemoteManagementObject: function () {
    let err = new Error("Object type not supported by OITF.");
    err.name = "TypeError";
    throw err;
  },

  createSearchManagerObject: function () {
    return new Object();
  }

};
