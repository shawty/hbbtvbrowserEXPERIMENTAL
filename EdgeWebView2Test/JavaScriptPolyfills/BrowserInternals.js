window.hbbtvBrowser = {};

window.hbbtvBrowser.currentChannelIndex = 0,

window.hbbtvBrowser.oipfObjects = {

  setUpObjects: function(){
    console.log("setting up static OIPF internal objects");

    // Get the actual channel data from the Vestel Channel Data Provider. (Sync for now, maybe async in future)
    this.channelList = JSON.parse(window.chrome.webview.hostObjects.sync.AsyncDataProviderInternal.GetChannelData);
    Object.assign(this.channelList, this.channelListFunctions);

    this.channelConfig.currentChannel = this.channelList[window.hbbtvBrowser.currentChannelIndex];

    document.addEventListener("onFoobar", function (e) {
      console.log("FOOBAR WAS RECIEVED!");
      console.table(e);
    });

  },

  // Global/Singleton objects
  videoBroadcast: {
    width: 0,
    height: 0,
    fullScreen: false,
    data: "",
    playState: 0,
    onChannelChangeError: null,
    onPlayStateChange: null,
    onChannelChangeSucceeded: null,
    onFullScreenChange: null,
    onFocus: null,
    onBlur: null,

    getChannelConfig: function(){
      console.log("BC getChannelConfig called.");
      return window.hbbtvBrowser.oipfObjects.channelConfig;
    },

    updateBroadcastText: function() {

      // NOT PART OF THE SPEC THIS IS AN INTERNAL HELPER FUNCTION
      let txt = document.getElementById("broadcastVidChannelName");
      if(txt){
        txt.textContent = window.hbbtvBrowser.oipfObjects.channelConfig.currentChannel.name;
      }

    },

    bindToCurrentChannel: function(){
      console.log("BC bindToCurrentChannel called.");

      let div = document.createElement("div");
      div.style = "height: 100%; width: 100%; background: url(http://portaltv.tv/images/static2.gif);";
      //img.src = "http://portaltv.tv/images/static2.gif";
      //img.src = "http://cheese/";

      let txt = document.createElement("h1");
      txt.id = "broadcastVidChannelName";
      txt.style = "padding-left: 10px; padding-top: 10px; color: #00FF00;";
      txt.textContent = this.getChannelConfig().currentChannel.name;
      div.appendChild(txt);

      this.innerHTML = "";
      this.appendChild(div);

    },
    createChannelObject: function(){
      console.log("BC createChannelObject called.");
    },
    setChannel: function(channel, trickPlay = false, contentAccessDescriptorURL = null){
      console.log("BC setChannel called.");
    },

    prevChannel: function(){
      console.log("BC prevChannel called.");

      window.hbbtvBrowser.currentChannelIndex = window.hbbtvBrowser.currentChannelIndex - 1;
      if(window.hbbtvBrowser.currentChannelIndex < 0) {
        window.hbbtvBrowser.currentChannelIndex = 0;
      }

      window.hbbtvBrowser.oipfObjects.channelConfig.currentChannel = window.hbbtvBrowser.oipfObjects.channelList[window.hbbtvBrowser.currentChannelIndex];
      window.hbbtvBrowser.oipfObjects.videoBroadcast.updateBroadcastText();

    },

    nextChannel: function(){
      console.log("BC nextChannel called.");

      window.hbbtvBrowser.currentChannelIndex = window.hbbtvBrowser.currentChannelIndex + 1;
      if(window.hbbtvBrowser.currentChannelIndex > (window.hbbtvBrowser.oipfObjects.channelList.length - 1)) {
        window.hbbtvBrowser.currentChannelIndex = (window.hbbtvBrowser.oipfObjects.channelList.length - 1);
      }

      window.hbbtvBrowser.oipfObjects.channelConfig.currentChannel = window.hbbtvBrowser.oipfObjects.channelList[window.hbbtvBrowser.currentChannelIndex];
      window.hbbtvBrowser.oipfObjects.videoBroadcast.updateBroadcastText();

    },

    stop: function(){
      console.log("BC stop called.");

      let tmpDiv = document.createElement("div");
      tmpDiv.style = "background-color: black; height: 100%; width: 100%;";
      this.innerHTML = "";
      this.appendChild(tmpDiv);

    },
    setFullScreen: function(){
      console.log("BC setFullScreen called.");
    },
    setVolume: function(){
      console.log("BC setVolume called.");
    },
    getVolume: function(){
      console.log("BC getVolume called.");
    },
    release: function(){
      console.log("BC release called.");
    }
  },

  videoMpeg: {},
  statusView: {},

  applicationManager: {

    WIDGET_INSTALLATION_STARTED: 0,
    WIDGET_INSTALLATION_COMPLETED: 1,
    WIDGET_INSTALLATION_FAILED: 2,
    WIDGET_UNINSTALLATION_STARTED: 3,
    WIDGET_UNINSTALLATION_COMPLETED: 4,
    WIDGET_UNINSTALLATION_FAILED: 5,
    WIDGET_ERROR_STORAGE_AREA_FULL: 10,
    WIDGET_ERROR_DOWNLOAD: 11,
    WIDGET_ERROR_INVALID_ZIP_ARCHIVE: 12,
    WIDGET_ERROR_INVALID_SIGNATURE: 13,
    WIDGET_ERROR_GENERIC: 14,
    WIDGET_ERROR_SIZE_EXCEEDED: 15,

    onLowMemory: null,
    onApplicationLoaded: null,
    onApplicationUnLoaded: null,
    onApplicationLoadError: null,
    onWidgetInstallation: null,
    onWidgetUnInstallation: null,
    
    widgets: [], // Type of WidgetDescriptorCollection

    getApplicationVisualizationMode: function() {
      return 3; // 1,2 or 3 (See 7.2.1.3 in OITF Specification
    },

    getOwnerApplication: function(document) {
      return null; // or an Application structure
    },

    getChildApplications: function(application) {
      return []; // Collection of Applications
    },

    gc: function() {
      // void
    },

    installWidget: function(uri) {
      // void
    },

    uninstallWidget: function(widgetDescriptor) {
      // void
    }

  },

  searchManager: {},
  metadataSearch: {},
  metadataQuery: {},
  searchResult: {},
  metadataSearchEvent: {},
  recordingScheduler: {},
  scheduledRecording: {},
  recording: {},

  channelConfig: {

    get channelList() { return window.hbbtvBrowser.oipfObjects.channelList; },  // ChannelList type
    favouriteLists: [], // FavouriteListCollection type
    currentFavouriteList: {}, // FavouriteList type
    
    onChannelScan: function() {}, // Function supplied by client to be called on channel scan event
    onChannelListUpdate: function() {}, // Function supplied by client to be called on channel list update event

    currentChannel: {}, // Channel type (Dummy holder, populated dynamically at run time)

    createFilteredList: function(blocked, favourite, hidden, favouriteListID) {},
    startScan: function(options, scanParameters) {},
    stopScan: function() {},
    createChannelList: function(bdr) {},
    createChannelObject: function(idType, onid, tsid, sid, sourceID, ipBroadcastID) {},
    createChannelScanParametersObject: function(idType) {}

  },

  channelList: [],
  channelListFunctions: {
    getChannel: function(channelID) {
      if(typeof(channelID)  === 'number'){
        let channel = this.find(o => o.majorChannel === channelID);
        return channel || null;
      } else {
        let channel = this.find(o => o.ccid === channelID);
        return channel || null;
      }
    },
    getChannelByTriplet: function(onid, tsid, sid) {
      let channel = this.find(o => o.onid === onid && o.tsid === tsid && o.sid === sid);
      return channel || null;
    },
    getChannelBySourceID(sourceID) {
      return null;
    },
  },

  channel: {},
  programme: {},
  avControl: {},
  parentalControlManager: {},
  parentalRatingScheme: {},
  parentalRatingSchemeCollection: {},
  parentalRating: {},
  parentalRatingCollection: {},
  bookmark: {},
  bookmarkCollection: {},
  configuration: {},
  discInfo: {},

};
window.hbbtvBrowser.oipfObjects.setUpObjects();

window.hbbtvBrowser.internals = {

  originalCreateElement: {},
  callbacksList: {},
  monitoredObjectTags: new WeakMap(),

  objectMutationObserver: new MutationObserver((mutations, observer) => {
    for(var i=0; i<mutations.length; i++) {
      if (mutations[i].attributeName == "type") {
        console.log("Object type change detected");
        window.hbbtvBrowser.internals.modifyObjectIfNeeded(mutations[i].target);
      }
    }
  }),

  setup: function(){
    console.log("Setting up browser internals");
    window.chrome.webview.addEventListener('message', this.postMessageHandler);

    this.originalCreateElement = document.createElement;

    document.createElement = (tagname ,options) => {
      let element = this.originalCreateElement.apply(document, [tagname, options]);
      if (tagname.toLowerCase() == "object") {
        console.log("Object created");
        this.attatchObjectMonitor(element);
      }
      return element;
    };

  },

  attatchObjectMonitor: function(objectElement) {

    if (this.monitoredObjectTags.get(objectElement)) {
        return;
    }
    
    this.monitoredObjectTags.set(objectElement,true);
    
    console.log("Object added to monitor list");

    this.objectMutationObserver.observe(objectElement,{ attributes: true, attributeFilter:["type"] });
    this.modifyObjectIfNeeded(objectElement);

  },

  modifyObjectIfNeeded: function(objectElement) {

    let newMimetype = objectElement.type.toLowerCase();

    switch(newMimetype){

      case "video/broadcast":
        this.addMixinsToBroadcastObject(objectElement);
        break;

      case "video/mpeg":
      case "video/mpg":
      case "video/mp4":
        console.log("Video stream object set up goes here...");
        break;

    }

  },

  addMixinsToBroadcastObject: function(objectElement){

    console.log("Setting up Broadcast object.");

    Object.assign(objectElement, window.hbbtvBrowser.oipfObjects.videoBroadcast);

    // We need to create a black background for this object to prevent chrome showing
    // the object not supported error.
    let tmpDiv = document.createElement("div");
    tmpDiv.style = "background-color: black; height: 100%; width: 100%;";
    objectElement.appendChild(tmpDiv);

  },

  addMixinsToVideoObject: function(objectElement){
  },

  postMessageHandler: function(e){
    // Find out what our message type is and act appropriately
    let data = e.data;
    //console.table(data);

    switch(data.messageType)
    {
      case "keypress":
        window.hbbtvBrowser.internals.sendVkeyCode(data.keyCode);
        break;

      case "event":
        window.hbbtvBrowser.internals.handleEventCall(data);
        break;

      case "genericEvent":
        let eventName = data.eventName;
        let eventData = data.eventData;
        let event = new CustomEvent(eventName, eventData);
        event.detail = eventData;
        document.dispatchEvent(event);
        break;

    }

  },

  sendVkeyCode: function(Vkey){
    document.dispatchEvent(new KeyboardEvent('keydown',{
      isTrusted: true,
      key: "",
      code: "",
      ctrlKey: false,
      shiftKey: false,
      altKey: false,
      metaKey: false,
      repeat: false,
      keyCode: Vkey,
      which: Vkey,
      bubbles: true,
      cancelable: true
    }));
  },

  addCallback: function(callbackName, callbackFunction){
    this.callbacksList[callbackName] = callbackFunction;
  },

  removeCallback: function(callbackName){
    delete this.callbacksList[callbackName];
  },

  handleEventCall: function(data){
    console.table(data);
    
    if(!data.eventName in this.callbacksList){
      console.log("Attempt to call unregistered callback: " + data.eventName);
      return;
    }

    switch(data.eventName)
    {
      case "channelListReady":
        this.callbacksList.channelListReady(data.status, JSON.stringify(data.channelData));
        break;

    }
  }

};

window.hbbtvBrowser.internals.setup();
