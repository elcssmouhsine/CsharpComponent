/**
 * Sample React Native App
 * https://github.com/facebook/react-native
 *
 * @format
 * @flow strict-local
 */

import React from 'react';
import {
  SafeAreaView,
  requireNativeComponent
} from 'react-native';

const CamUserControl = requireNativeComponent('CamUserControl');
const App: () => React$Node = () => {
  return (
    <>
      <SafeAreaView>
        <CamUserControl label="test" />
      </SafeAreaView>
    </>
  );
};

export default App;
