import React, { Component } from 'react';
import { Col, Grid, Row, Button, Glyphicon } from 'react-bootstrap';
import { BtnCarrito } from './BtnCarrito';

export class Search extends Component {
    displayName = Search.name

    constructor(props) {
        super(props);
    }

    render() {
        return (
            <Row>
                <Col sm={8}>
                    <input placeholder="Buscar" /> <Glyphicon glyph="search" />
                </Col>
                <Col sm={4}>
                    <BtnCarrito></BtnCarrito>
                </Col>
                
            </Row>
        );
    }
}
